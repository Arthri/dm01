using Sougen;
using SGTest = Sougen.UnitTests.CSharpIncrementalSourceGeneratorVerifier<Sougen.ExceptionGenerator>;

namespace Sougen.UnitTests;

public class ExceptionGeneratorTests
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
                    (typeof(ExceptionGenerator), "Soup.cs", SourceText.From("class Soup {}", Encoding.UTF8)),
                    (typeof(ExceptionGenerator), "CarrotSoup.cs", SourceText.From("class CarrotSoup : Soup {}", Encoding.UTF8)),
                    (typeof(ExceptionGenerator), "TomatoSoup.cs", SourceText.From("class TomatoSoup : Soup {}", Encoding.UTF8)),
                    (typeof(ExceptionGenerator), "PotatoSoup.cs", SourceText.From("class PotatoSoup : Soup {}", Encoding.UTF8)),
                    (typeof(ExceptionGenerator), "CelerySoup.cs", SourceText.From("class CelerySoup : Soup {}", Encoding.UTF8)),
                    (typeof(ExceptionGenerator), "GarlicSoup.cs", SourceText.From("class GarlicSoup : Soup {}", Encoding.UTF8)),
                    (typeof(ExceptionGenerator), "LentilSoup.cs", SourceText.From("class LentilSoup : Soup {}", Encoding.UTF8)),
                }
            }
        };

        return test.RunAsync();
    }
}
