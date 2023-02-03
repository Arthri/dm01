using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.Text;
using System.Text;

namespace Sougen
{
    [Generator(LanguageNames.CSharp)]
    public class SoupGenerator : IIncrementalGenerator
    {
        public virtual void Initialize(IncrementalGeneratorInitializationContext context)
        {
            context.RegisterPostInitializationOutput(context2 =>
            {
                context2.AddSource("Soup.cs", SourceText.From("class Soup {}", Encoding.UTF8));
                context2.AddSource("CarrotSoup.cs", SourceText.From("class CarrotSoup : Soup {}", Encoding.UTF8));
                context2.AddSource("TomatoSoup.cs", SourceText.From("class TomatoSoup : Soup {}", Encoding.UTF8));
                context2.AddSource("PotatoSoup.cs", SourceText.From("class PotatoSoup : Soup {}", Encoding.UTF8));
                context2.AddSource("CelerySoup.cs", SourceText.From("class CelerySoup : Soup {}", Encoding.UTF8));
                context2.AddSource("GarlicSoup.cs", SourceText.From("class GarlicSoup : Soup {}", Encoding.UTF8));
                context2.AddSource("LentilSoup.cs", SourceText.From("class LentilSoup : Soup {}", Encoding.UTF8));
            });
        }
    }
}
