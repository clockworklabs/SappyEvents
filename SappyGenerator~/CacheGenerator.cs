using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Text;

namespace SappyGenerator
{
    [Generator]
    public class CacheGenerator : IIncrementalGenerator
    {
        private const string SapTargetAttribute = "Sappy.SapTargetAttribute";
        
        void IIncrementalGenerator.Initialize(IncrementalGeneratorInitializationContext context)
        {
            var methodSymbols =
                context.SyntaxProvider
                    .CreateSyntaxProvider(
                        predicate: static (s, _) => IsSyntaxTargetForGeneration(s), 
                        transform: static (ctx, _) => GetSemanticTargetForGeneration(ctx))
                    .Where(static m => m is not null);
            
            var compilation = context.CompilationProvider.Combine(methodSymbols.Collect());

            context.RegisterSourceOutput(compilation, static (spc, source) => Execute(source.Item2, spc));
        }

        private class TypeInfo
        {
            public INamedTypeSymbol Symbol { get; }
            public ReadOnlyCollection<MethodInfo> Methods { get; }
            
            public int NestedMethodsCount { get; }
            public int FlatMethodsCount { get; }
            
            public string FullName { get; }
            public string Name { get; }
            public string NamespaceName { get; }

            public TypeInfo(INamedTypeSymbol symbol, ReadOnlyCollection<MethodInfo> methods)
            {
                Symbol = symbol;
                Methods = methods;
                
                NestedMethodsCount = methods.Count(m => m.Nested);
                FlatMethodsCount = methods.Count - NestedMethodsCount;

                var ns = symbol.ContainingNamespace;
                var namespaceName = ns is { IsGlobalNamespace: false } ? symbol.ContainingNamespace?.ToDisplayString() : null;
                NamespaceName = namespaceName;
                FullName = symbol.GetFullName(true);
                Name = symbol.GetName(true);
            }
        }
        
        private class MethodInfo
        {
            public IMethodSymbol Symbol { get; }
            public string Name { get; }
            public string DelegateType { get; }
            public string GroupName { get; }
            public bool Nested { get; }
            
            public INamedTypeSymbol ContainingSymbol { get; }

            public MethodInfo(IMethodSymbol symbol)
            {
                Symbol = symbol;
                Name = symbol.Name;

                var attributeArguments = symbol.GetAttributeArguments(SapTargetAttribute);
                var delegateTypeArgument = attributeArguments[0];

                if (delegateTypeArgument.Value is INamedTypeSymbol namedTypeSymbol)
                {
                    DelegateType = namedTypeSymbol.GetFullName(true);
                }
                else
                {
                    var stringBuilder = new StringBuilder();
                    var returnType = symbol.ReturnType;
                    var hasReturnType = returnType.GetFullName(false) != "System.Void";
                    stringBuilder.Append(hasReturnType ? "System.Func" : "System.Action");
                    var parameters = symbol.Parameters.Select(s => s.Type).ToList();
                    if (hasReturnType)
                    {
                        parameters.Add(returnType);
                    }
                    var parametersCount = parameters.Count;
                    if (parametersCount > 0)
                    {
                        stringBuilder.Append("<");
                        for (var i = 0; i < parametersCount; i++)
                        {
                            var parameter = parameters[i];
                            stringBuilder.Append($"{parameter.GetFullName(true)}");
                            if (i + 1 < parametersCount)
                            {
                                stringBuilder.Append(", ");
                            }
                        }
                        stringBuilder.Append(">");
                    }

                    DelegateType = stringBuilder.ToString();
                }

                if (attributeArguments[1].Value is string groupName)
                {
                    GroupName = groupName;
                }
                if (attributeArguments[2].Value is bool nested)
                {
                    Nested = nested;
                }
                
                ContainingSymbol = (INamedTypeSymbol)symbol.ContainingSymbol;
            }
        }
        
        private static bool IsSyntaxTargetForGeneration(SyntaxNode node) => node is MethodDeclarationSyntax { AttributeLists: { Count: > 0 } };
            
        private static MethodInfo GetSemanticTargetForGeneration(GeneratorSyntaxContext context)
        {
            var node = (MethodDeclarationSyntax)context.Node;
            
            var semanticModel = context.SemanticModel;

            foreach (var attributeList in node.AttributeLists)
            {
                foreach (var attribute in attributeList.Attributes)
                {
                    if (ModelExtensions.GetSymbolInfo(semanticModel, attribute).Symbol is not IMethodSymbol attributeSymbol) continue;

                    var attributeTypeSymbol = attributeSymbol.ContainingType;
                    while (attributeTypeSymbol != null)
                    {
                        var fullName = attributeTypeSymbol.GetFullName(false);
                        if (fullName == SapTargetAttribute)
                        {
                            return new MethodInfo(semanticModel.GetDeclaredSymbol(node));
                        }
                        
                        attributeTypeSymbol = attributeTypeSymbol.BaseType;
                    }
                }
            }

            return null;
        }
        
        private static void Execute(ImmutableArray<MethodInfo> allMethods, SourceProductionContext context)
        {
            if (allMethods.IsDefaultOrEmpty) return;
            
            var distinctMethods = allMethods.Distinct();
            
            var targetTypes = new Dictionary<string, INamedTypeSymbol>();
            var groupedMethods = new Dictionary<string, List<MethodInfo>>();
            foreach (var methodInfo in distinctMethods)
            {
                context.CancellationToken.ThrowIfCancellationRequested();

                if (string.IsNullOrWhiteSpace(methodInfo.GroupName)) continue;

                var containingSymbol = methodInfo.ContainingSymbol;
                var containingTypeName = methodInfo.ContainingSymbol.GetFullName(true);

                if (!targetTypes.ContainsKey(containingTypeName))
                {
                    targetTypes.Add(containingTypeName, containingSymbol);
                }

                if (!groupedMethods.TryGetValue(containingTypeName, out var list))
                {
                    list = new List<MethodInfo>();
                    groupedMethods.Add(containingTypeName, list);
                }
                
                list.Add(methodInfo);
            }

            var targets = new List<TypeInfo>();
            foreach (var keyValue in groupedMethods)
            {
                context.CancellationToken.ThrowIfCancellationRequested();
                
                var containingTypeName = keyValue.Key;
                var methods = keyValue.Value;
                
                methods.Sort((a, b) => a.Nested == b.Nested ? a.GroupName.CompareTo(b.GroupName, StringComparison.Ordinal) : a.Nested.CompareTo(b.Nested));
                
                targets.Add(new TypeInfo(targetTypes[containingTypeName], methods.AsReadOnly()));
            }
            
            foreach (var target in targets)
            {
                var sourceText = GenerateSource(target);
                if (!string.IsNullOrWhiteSpace(sourceText))
                {
                    var hintName = $"{target.Symbol.GetFullName(false)}_SappyGenerator.g.cs";
                    context.AddSource(hintName, SourceText.From(sourceText, Encoding.UTF8));
                }
            }
        }
        
        private static string GenerateSource(TypeInfo target)
        {
            var containingSymbol = target.Symbol;
            
            if (!containingSymbol.IsPartial() || !containingSymbol.IsAccessible(true)) return null;
            
            var namespaceName = target.NamespaceName;
            var hasNamespace = !string.IsNullOrWhiteSpace(namespaceName);

            var builder = new StringBuilder();
            builder.AppendLine("// Auto-generated code by SappyGenerator");
            if (hasNamespace)
            {
                builder.AppendLine($"namespace {namespaceName}");
                builder.AppendLine("{");
            }

            var containingTypes = new List<INamedTypeSymbol>();
            var parent = containingSymbol.ContainingType;
            while (parent != null)
            {
                containingTypes.Add(parent);
                parent = parent.ContainingType;
            }
            containingTypes.Reverse();
            foreach (var containingType in containingTypes)
            {
                var containingAccessibility = containingType.DeclaredAccessibility.ToModifiers();
                builder.AppendLine($"{containingAccessibility}{(containingType.IsStatic ? " static" : "")} partial class {containingType.GetName(true)}");
                builder.AppendLine("{");
            }
            
            var classAccessibility = containingSymbol.DeclaredAccessibility.ToModifiers();
            builder.AppendLine($"    {classAccessibility}{(containingSymbol.IsStatic ? " static" : "")} partial class {target.Name}");
            builder.AppendLine("    {");
            
            var methods = target.Methods;
            
            // Flat
            for(int i = 0, n = target.FlatMethodsCount; i < n; i++)
            {
                var method = methods[i];
                var methodGroupName = method.GroupName;
                var symbol = method.Symbol;
                var methodName = symbol.Name;
                var cachedFieldName = $"_{methodGroupName}{methodName}";
                var accessibility = symbol.DeclaredAccessibility.ToModifiers();
                var staticKeyword = symbol.IsStatic ? "static " : "";

                builder.AppendLine($"        private {staticKeyword}global::Sappy.SapTarget<{method.DelegateType}> {cachedFieldName};");
                builder.AppendLine($"        {accessibility} {staticKeyword}global::Sappy.SapTarget<{method.DelegateType}> {methodGroupName}{methodName} => {cachedFieldName} ??= new global::Sappy.SapTarget<{method.DelegateType}>({methodName});");
            }
            
            // Nested
            if(target.NestedMethodsCount > 0)
            {
                var staticGroups = new Dictionary<string, bool>();
                for(int i = target.FlatMethodsCount, n = target.Methods.Count; i < n; i++)
                {
                    var method = methods[i];
                    var groupName = method.GroupName;

                    if (!staticGroups.TryGetValue(groupName, out var wasStatic))
                    {
                        wasStatic = true;
                    }
                    
                    staticGroups[groupName] = containingSymbol.IsStatic || (method.Symbol.IsStatic && wasStatic);
                }

                string? methodGroupName = null;
                for(int i = target.FlatMethodsCount, n = target.Methods.Count; i < n; i++)
                {
                    var method = methods[i];
                    if (methodGroupName != method.GroupName)
                    {
                        if (methodGroupName != null)
                        {
                            builder.AppendLine("        }");
                        }
                        methodGroupName = method.GroupName;
                        var isStaticGroup = staticGroups.TryGetValue(methodGroupName, out var isStatic) && isStatic;
                        if (!isStaticGroup)
                        {
                            builder.AppendLine($"        private {methodGroupName}Group _{methodGroupName};");
                            builder.AppendLine($"        private {methodGroupName}Group {methodGroupName} => _{methodGroupName} ??= new {methodGroupName}Group(this);");
                        }
                        builder.AppendLine($"        private{(isStaticGroup ? " static" : "")} partial class {methodGroupName}{(isStaticGroup ? "" : "Group")}");
                        builder.AppendLine("        {");
                        if (!isStaticGroup)
                        {
                            builder.AppendLine($"            private {containingSymbol.GetName(true)} Instance {{ get; }}");
                            builder.AppendLine($"            public {methodGroupName}Group({containingSymbol.GetName(true)} instance) {{ Instance = instance; }}");
                        }
                    }

                    var symbol = method.Symbol;
                    var methodName = symbol.Name;
                    var cachedFieldName = $"_{methodName}";
                    var isStaticMethod = symbol.IsStatic || containingSymbol.IsStatic;
                    var staticKeyword = isStaticMethod ? "static " : "";

                    builder.AppendLine($"            private {staticKeyword}global::Sappy.SapTarget<{method.DelegateType}> {cachedFieldName};");
                    builder.AppendLine($"            public {staticKeyword}global::Sappy.SapTarget<{method.DelegateType}> {methodName} => {cachedFieldName} ??= new global::Sappy.SapTarget<{method.DelegateType}>({(isStaticMethod ? $"{containingSymbol.GetName(true)}." : "Instance.")}{methodName});");
                }
                builder.AppendLine("        }");
            }
            
            builder.AppendLine("    }");
            
            foreach (var _ in containingTypes)
            {
                builder.AppendLine("}");
            }

            if(hasNamespace) {
                builder.AppendLine("}");
            }

            return builder.ToString();
        }
    }
}