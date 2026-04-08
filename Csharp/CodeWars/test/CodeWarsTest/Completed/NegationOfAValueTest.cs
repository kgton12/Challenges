using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class NegationOfAValueTest
{
    private static IEnumerable<TestCaseData> TestCases
    {
        get
        {
            yield return new TestCaseData("!", false).Returns(true).SetDescription("Basic Test");
            yield return new TestCaseData("!", true).Returns(false).SetDescription("Basic Test");
            yield return new TestCaseData("!!!", false).Returns(true).SetDescription("Basic Test");
        }
    }

    [Test, TestCaseSource(nameof(TestCases))]
    public bool Test(string str, bool value) => NegationOfAValue.NegationValue(str, value);
}