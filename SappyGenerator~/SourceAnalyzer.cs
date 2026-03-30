using System.Collections.Immutable;
using System.Linq;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Diagnostics;

namespace SappyGenerator
{
    [DiagnosticAnalyzer(LanguageNames.CSharp)]
    public class SourceAnalyzer : DiagnosticAnalyzer
    {
        private const string SapEventAttribute = "Sappy.SapEventAttribute";
        private const string IgnoreSappyErrorAttribute = "Sappy.IgnoreSappyErrorAttribute";
        private const string SappyAttribute = "Sappy.SappyAttribute";
        
        private static readonly DiagnosticDescriptor ErrorRule = new(
            "CachedRule",
            "Only cached sap targets can subscribe and unsubscribe from sap signals",
            "{0} must be a cached sap target",
            "Usage",
            DiagnosticSeverity.Error,
            true,
            "[Longer than title]",
            null // TODO: Help link to documentation
        );
        
        private static readonly DiagnosticDescriptor WarningRule = new(
            "CachedRecommendationRule",
            "Caching delegates can avoid garbage allocation",
            "{0} could be cached and avoid garbage",
            "Usage",
            DiagnosticSeverity.Warning,
            true,
            "[Longer than title]",
            null // TODO: Help link to documentation
        );

        public override ImmutableArray<DiagnosticDescriptor> SupportedDiagnostics => ImmutableArray.Create(ErrorRule, WarningRule);
        
        public override void Initialize(AnalysisContext context)
        {
            context.EnableConcurrentExecution();
            context.ConfigureGeneratedCodeAnalysis(GeneratedCodeAnalysisFlags.None);
            context.RegisterSyntaxNodeAction(SapEventsCheck, SyntaxKind.AddAssignmentExpression, SyntaxKind.SubtractAssignmentExpression);
            context.RegisterCompilationStartAction(compilationContext =>
            {
                var parseOptions = (CSharpParseOptions)compilationContext.Compilation.SyntaxTrees.FirstOrDefault()?.Options;
                if (parseOptions != null)
                {
                    if (parseOptions.PreprocessorSymbolNames.Contains("SAPPY_ERRORS"))
                    {
                        compilationContext.RegisterSyntaxNodeAction(SappyErrors, SyntaxKind.AddAssignmentExpression, SyntaxKind.SubtractAssignmentExpression);
                    } else if (parseOptions.PreprocessorSymbolNames.Contains("SAPPY_WARNINGS"))
                    {
                        compilationContext.RegisterSyntaxNodeAction(SappyWarnings, SyntaxKind.AddAssignmentExpression, SyntaxKind.SubtractAssignmentExpression);
                    }
                }
            });
        }

        private static void SapEventsCheck(SyntaxNodeAnalysisContext context)
        {
            if (!IsPotentialCandidate(context, out var eventSymbol, out var delegateSymbol, out var location)) return;
            
            var hasSapEventAttribute = eventSymbol.GetAttributes().Any(attr => attr.AttributeClass?.GetFullName(true) == SapEventAttribute);
            if (!hasSapEventAttribute) return;
            
            var diagnostic = Diagnostic.Create(
                ErrorRule,
                location,
                delegateSymbol);

            context.ReportDiagnostic(diagnostic);
        }

        private static void SappyErrors(SyntaxNodeAnalysisContext context)
        {
            if (!IsPotentialCandidate(context, out var eventSymbol, out var delegateSymbol, out var location)) return;

            if (!InSappyType(eventSymbol) && !InSappyType(delegateSymbol)) return;
            
            var diagnostic = Diagnostic.Create(
                ErrorRule,
                location,
                delegateSymbol);

            context.ReportDiagnostic(diagnostic);
        }

        private static void SappyWarnings(SyntaxNodeAnalysisContext context)
        {
            if (!IsPotentialCandidate(context, out var eventSymbol, out var delegateSymbol, out var location)) return;

            if (!InSappyType(eventSymbol) && !InSappyType(delegateSymbol)) return;
            
            var diagnostic = Diagnostic.Create(
                WarningRule,
                location,
                delegateSymbol);

            context.ReportDiagnostic(diagnostic);
        }

        private static bool IsPotentialCandidate(SyntaxNodeAnalysisContext context, out IEventSymbol eventSymbol, out ISymbol delegateSymbol, out Location location)
        {
            var assignment = (AssignmentExpressionSyntax)context.Node;
            eventSymbol = null;
            delegateSymbol = context.SemanticModel.GetSymbolInfo(assignment.Right).Symbol;
            location = null;
            if (delegateSymbol == null) return false;
            if (delegateSymbol.Kind is SymbolKind.Property or SymbolKind.Field) return false;
            if (delegateSymbol.HasAttribute(IgnoreSappyErrorAttribute)) return false;
            eventSymbol = context.SemanticModel.GetSymbolInfo(assignment.Left).Symbol as IEventSymbol;
            if (eventSymbol == null) return false;
            location = assignment.Right.GetLocation();
            return true;
        }

        private static bool InSappyType(ISymbol symbol)
        {
            if (symbol == null) return false;
            
            if (symbol is INamedTypeSymbol namedSymbol)
            {
                if (namedSymbol.HasAttribute(SappyAttribute)) return true;
                if (InSappyType(namedSymbol.BaseType)) return true;
            }
            
            var eventContainingType = symbol.ContainingType;
            while (eventContainingType != null)
            {
                if (InSappyType(eventContainingType)) return true;
                eventContainingType = eventContainingType.ContainingType;
            }

            return false;
        }
    }
}