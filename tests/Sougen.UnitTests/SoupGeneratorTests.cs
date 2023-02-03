using Sougen;
using SGTest = Sougen.UnitTests.CSharpIncrementalSourceGeneratorVerifier<Sougen.SoupGenerator>;

namespace Sougen.UnitTests;

public class SoupGeneratorTests
{
    [Fact]
    public Task Test()
    {
        var test = new SGTest.Test
        {
            TestState =
            {
                GeneratedSources =
                {
                    (typeof(SoupGenerator), "Soup.cs", SourceText.From("class Soup {}", Encoding.UTF8)),
                    (typeof(SoupGenerator), "CarrotSoup.cs", SourceText.From("class CarrotSoup : Soup {}", Encoding.UTF8)),
                    (typeof(SoupGenerator), "PotatoSoup.cs", SourceText.From("class PottoSoup : Soup {}", Encoding.UTF8)),
                    (typeof(SoupGenerator), "TomatoSoup.cs", SourceText.From("class TomatoSoup : Soup {}", Encoding.UTF8)),
                    (typeof(SoupGenerator), "CelerySoup.cs", SourceText.From("class CelerySoup : Soup {}", Encoding.UTF8)),
                    (typeof(SoupGenerator), "GarlicSoup.cs", SourceText.From("class GarlicSoup : Soup {}", Encoding.UTF8)),
                    (typeof(SoupGenerator), "LentilSoup.cs", SourceText.From("class LentilSoup : Soup {}", Encoding.UTF8)),
                }
            }
        };

        return test.RunAsync();
    }
}
