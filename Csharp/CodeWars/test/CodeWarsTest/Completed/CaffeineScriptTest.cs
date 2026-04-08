using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class CaffeineScriptTest
{
    private static IEnumerable<TestCaseData> TestCases
    {
        get
        {
            yield return new TestCaseData(1).Returns("mocha_missing!");
            yield return new TestCaseData(3).Returns("Java");
            yield return new TestCaseData(6).Returns("JavaScript");
            yield return new TestCaseData(12).Returns("CoffeeScript");
        }
    }

    [Test, TestCaseSource(nameof(TestCases))]
    public string Test(int n) => CaffeineScript.CaffeineBuzz(n);
}
