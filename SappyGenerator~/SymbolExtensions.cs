using System;
using System.Collections.Immutable;
using System.Linq;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace SappyGenerator
{
    public static class SymbolExtensions
    {
        public static bool IsAccessible(this ITypeSymbol typeSymbol, bool privateAllowed)
        {
            var containingType = typeSymbol.ContainingType;
            while (containingType != null)
            {
                if (!containingType.IsAccessible(privateAllowed))
                {
                    return false;
                }

                containingType = containingType.ContainingType;
            }
            
            if (typeSymbol is ITypeParameterSymbol)
            {
                return true;
            }
            
            return privateAllowed || typeSymbol.DeclaredAccessibility is Accessibility.Public or Accessibility.ProtectedOrInternal or Accessibility.Internal;
        }
        public static bool IsAccessible(this IMethodSymbol methodSymbol, bool privateAllowed)
        {
            if (privateAllowed) return true;
            
            var containingType = methodSymbol.ContainingType;
            while (containingType != null)
            {
                if (!containingType.IsAccessible(false))
                {
                    return false;
                }

                containingType = containingType.ContainingType;
            }

            return methodSymbol.DeclaredAccessibility is Accessibility.Public or Accessibility.ProtectedOrInternal or Accessibility.Internal;
        }

        public static string GetName(this ITypeSymbol typeSymbol, bool includeGenerics) => includeGenerics ? $"{typeSymbol.Name}{typeSymbol.GetGenericsParametersName(false)}" : typeSymbol.Name;
        public static string GetFullName(this ITypeSymbol typeSymbol, bool includeGenerics)
        {
            if (typeSymbol == null)
            {
                return string.Empty;
            }
            
            var name = typeSymbol.Name;
            if (typeSymbol is ITypeParameterSymbol)
            {
                return name;
            }

            if (includeGenerics)
            {
                var genericName = typeSymbol.GetGenericsName(false);
                if (!string.IsNullOrWhiteSpace(genericName))
                {
                    name = $"{name}{genericName}";
                }
            }

            var containingType = typeSymbol.ContainingType;
            if (containingType != null)
            {
                return $"{containingType.GetFullName(includeGenerics)}.{name}";
            }

            var containingNamespace = typeSymbol.ContainingNamespace;
            if (containingNamespace == null || containingNamespace.IsGlobalNamespace)
            {
                return name;
            }

            return $"{typeSymbol.ContainingNamespace.ToDisplayString()}.{name}";
        }
        
        public static bool IsGenericDefinition(this ITypeSymbol typeSymbol)
        {
            var containingType = typeSymbol.ContainingType;
            while(containingType != null)
            {
                if (containingType.Arity <= 0)
                {
                    continue;
                }

                var containingTypeArguments = containingType.TypeArguments;
                for(int i = 0, n = containingTypeArguments.Length; i < n; i++)
                {
                    var typeArgument = containingTypeArguments[i];
                    if (typeArgument is not ITypeParameterSymbol)
                    {
                        return false;
                    }
                }
                containingType = containingType.ContainingType;
            }
            
            if (typeSymbol is not INamedTypeSymbol { Arity: > 0 } namedTypeSymbol) return false;

            var typeArguments = namedTypeSymbol.TypeArguments;
            for(int i = 0, n = typeArguments.Length; i < n; i++)
            {
                var typeArgument = typeArguments[i];
                if (typeArgument is not ITypeParameterSymbol)
                {
                    return false;
                }
            }
                
            return true;
        }
        public static bool HasGenericParameters(this ITypeSymbol typeSymbol)
        {
            if (typeSymbol is not INamedTypeSymbol { Arity: > 0 } namedTypeSymbol) return false;
            
            var typeArguments = namedTypeSymbol.TypeArguments;
            for(int i = 0, n = typeArguments.Length; i < n; i++)
            {
                var typeArgument = typeArguments[i];
                if (typeArgument is ITypeParameterSymbol)
                {
                    return true;
                }
            }
                
            return false;
        }
        
        public static string GetGenericsName(this ITypeSymbol typeSymbol, bool containingTypes)
        {
            var genericTypes = typeSymbol.GetGenericsTypes(containingTypes);
            if (!string.IsNullOrWhiteSpace(genericTypes))
            {
                genericTypes = $"<{genericTypes}>";
            }

            return genericTypes;
        }
        
        private static string GetGenericsTypes(this ITypeSymbol typeSymbol, bool containingTypes)
        {
            string genericTypes = null;

            if (containingTypes)
            {
                var containingType = typeSymbol.ContainingType;
                if (containingType != null)
                {
                    genericTypes = containingType.GetGenericsTypes(true);
                }
            }

            var hasGenericTypes = !string.IsNullOrWhiteSpace(genericTypes);
            
            if (typeSymbol is INamedTypeSymbol { Arity: > 0 } namedTypeSymbol)
            {
                var typeArguments = namedTypeSymbol.TypeArguments;
                for (int i = 0, n = typeArguments.Length; i < n; i++)
                {
                    var typeArgument = typeArguments[i];
                    var typeArgumentFullName = typeArgument.GetFullName(true);
                    genericTypes = $"{genericTypes}{(hasGenericTypes ? ", " : string.Empty)}{typeArgumentFullName}";

                    hasGenericTypes = true;
                }
            }

            return genericTypes;
        }
        
        public static string GetGenericsParametersName(this ITypeSymbol typeSymbol, bool containingTypes)
        {
            var genericTypes = typeSymbol.GetGenericsParameters(containingTypes);
            if (!string.IsNullOrWhiteSpace(genericTypes))
            {
                genericTypes = $"<{genericTypes}>";
            }

            return genericTypes;
        }
        
        private static string GetGenericsParameters(this ITypeSymbol typeSymbol, bool containingTypes)
        {
            string genericTypes = null;

            if (containingTypes)
            {
                var containingType = typeSymbol.ContainingType;
                if (containingType != null)
                {
                    genericTypes = containingType.GetGenericsTypes(true);
                }
            }

            var hasGenericTypes = !string.IsNullOrWhiteSpace(genericTypes);
            
            if (typeSymbol is INamedTypeSymbol { Arity: > 0 } namedTypeSymbol)
            {
                var typeArguments = namedTypeSymbol.TypeArguments;
                for (int i = 0, n = typeArguments.Length; i < n; i++)
                {
                    var typeArgument = typeArguments[i];
                    if (typeArgument is not ITypeParameterSymbol typeParameter)
                    {
                        continue;
                    }
                    var typeArgumentFullName = typeParameter.GetFullName(true);
                    genericTypes = $"{genericTypes}{(hasGenericTypes ? ", " : string.Empty)}{typeArgumentFullName}";

                    hasGenericTypes = true;
                }
            }

            return genericTypes;
        }
        
        public static string GetGenericsConstraints(this ITypeSymbol typeSymbol, bool containingTypes)
        {
            string constraintsString = null;

            if (containingTypes)
            {
                var containingType = typeSymbol.ContainingType;
                if (containingType != null)
                {
                    constraintsString = containingType.GetGenericsConstraints(true);
                }
            }

            if (typeSymbol is INamedTypeSymbol { Arity: > 0 } namedTypeSymbol)
            {
                var typeArguments = namedTypeSymbol.TypeArguments;
                for(int i = 0, n = typeArguments.Length; i < n; i++)
                {
                    var typeArgument = typeArguments[i];
                    var hasConstraints = false;
                    if (typeArgument is not ITypeParameterSymbol typeParameter)
                    {
                        continue;
                    }

                    var parameterConstraints = $" where {typeParameter.Name} : ";

                    if (typeParameter.HasNotNullConstraint)
                    {
                        parameterConstraints = $"{parameterConstraints}notnull";
                        hasConstraints = true;
                    }

                    if (typeParameter.HasReferenceTypeConstraint)
                    {
                        parameterConstraints = $"{parameterConstraints}{(hasConstraints ? ", " : string.Empty)}class";
                        hasConstraints = true;
                    } else if (typeParameter.HasUnmanagedTypeConstraint)
                    {
                        parameterConstraints = $"{parameterConstraints}{(hasConstraints ? ", " : string.Empty)}unmanaged";
                        hasConstraints = true;
                    } else if (typeParameter.HasValueTypeConstraint)
                    {
                        parameterConstraints = $"{parameterConstraints}{(hasConstraints ? ", " : string.Empty)}struct";
                        hasConstraints = true;
                    }

                    var constraintTypes = typeParameter.ConstraintTypes;
                    foreach (var constraintType in constraintTypes)
                    {
                        var constraintFullName = constraintType.GetFullName(true);
                        parameterConstraints = $"{parameterConstraints}{(hasConstraints ? ", " : string.Empty)}{constraintFullName}";
                        hasConstraints = true;
                    }

                    if (typeParameter.HasConstructorConstraint)
                    {
                        parameterConstraints = $"{parameterConstraints}{(hasConstraints ? ", " : string.Empty)}new()";
                        hasConstraints = true;
                    }

                    if (hasConstraints)
                    {
                        constraintsString = $"{constraintsString}{parameterConstraints}";
                    }
                }
            }

            return constraintsString;
        }
        
        public static bool HasAttribute(this ISymbol typeSymbol, string fullName)
        {
            foreach (var attributeData in typeSymbol.GetAttributes())
            {
                var attributeClass = attributeData.AttributeClass;
                while (attributeClass != null)
                {
                    var attributeFullName = attributeClass.GetFullName(false);
                    if (attributeFullName == fullName)
                    {
                        return true;
                    }
            
                    attributeClass = attributeClass.BaseType;
                }
            }

            return false;
        }
        
        public static ImmutableArray<TypedConstant> GetAttributeArguments(this ISymbol typeSymbol, string fullName)
        {
            foreach (var attributeData in typeSymbol.GetAttributes())
            {
                var attributeClass = attributeData.AttributeClass;
                while (attributeClass != null)
                {
                    var attributeFullName = attributeClass.GetFullName(false);
                    if (attributeFullName == fullName)
                    {
                        return attributeData.ConstructorArguments;
                    }
            
                    attributeClass = attributeClass.BaseType;
                }
            }

            return default;
        }

        public static bool IsPartial(this INamedTypeSymbol symbol)
        {
            var isPartial = symbol.DeclaringSyntaxReferences.Any(r => r.GetSyntax() is ClassDeclarationSyntax cds && cds.Modifiers.Any(SyntaxKind.PartialKeyword));
            if (!isPartial) return false;
            var containingType = symbol.ContainingType;
            return containingType == null || containingType.IsPartial();
        }
        
        public static string ToModifiers(this Accessibility accessibility) => accessibility switch
        {
            Accessibility.Private => "private",
            Accessibility.ProtectedAndInternal => "private protected",
            Accessibility.Protected => "protected",
            Accessibility.Internal => "internal",
            Accessibility.ProtectedOrInternal => "protected internal",
            Accessibility.Public => "public",
            _ => throw new ArgumentOutOfRangeException()
        };
        
        public static string ToName(this Accessibility accessibility) => accessibility switch
        {
            Accessibility.Private => "Private",
            Accessibility.ProtectedAndInternal => "PrivateProtected",
            Accessibility.Protected => "Protected",
            Accessibility.Internal => "Internal",
            Accessibility.ProtectedOrInternal => "ProtectedInternal",
            Accessibility.Public => "Public",
            _ => throw new ArgumentOutOfRangeException()
        };
    }
}