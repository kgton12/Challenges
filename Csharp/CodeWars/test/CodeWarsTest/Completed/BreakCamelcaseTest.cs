
using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class BreakCamelcaseTest
{
    private static IEnumerable<TestCaseData> TestCases
    {
        get
        {
            yield return new TestCaseData("camelCasing").Returns("camel Casing");
            yield return new TestCaseData("camelCasingTest").Returns("camel Casing Test");
        }
    }

    [Test, TestCaseSource(nameof(TestCases))]
    public static string Test(string str) => BreakcamelCase.BreakCamelCase(str);
}
