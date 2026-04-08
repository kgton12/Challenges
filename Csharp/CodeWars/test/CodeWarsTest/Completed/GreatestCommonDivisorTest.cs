using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class GreatestCommonDivisorTest
{
    private static IEnumerable<TestCaseData> TestCases
    {
        get
        {
            yield return new TestCaseData(30, 12).Returns(6);
            yield return new TestCaseData(8, 9).Returns(1);
            yield return new TestCaseData(1, 1).Returns(1);
        }
    }

    [Test, TestCaseSource(nameof(TestCases))]
    public int Test(int a, int b) => GreatestCommonDivisor.Gcd(a, b);
}
