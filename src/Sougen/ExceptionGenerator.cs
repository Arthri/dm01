using Microsoft.CodeAnalysis;

namespace Sougen
{
    [Generator(LanguageNames.CSharp)]
    public class ExceptionGenerator : IIncrementalGenerator
    {
        public void Initialize(IncrementalGeneratorInitializationContext context)
        {
            context
                .RegisterSourceOutput(
                    context.CompilationProvider.Select((compilation, cancellation) => 1),
                    (context2, provider) => context2.ReportDiagnostic(
                        Diagnostic.Create(
                            new DiagnosticDescriptor("SXG0001", "Soup.", "Soup.", "Soup", DiagnosticSeverity.Error, true),
                            null
                        )
                    )
                );
        }
    }
}
