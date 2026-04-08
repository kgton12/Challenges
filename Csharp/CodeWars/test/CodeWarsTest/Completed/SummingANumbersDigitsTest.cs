using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class SummingANumbersDigitsTest
{
    private static IEnumerable<TestCaseData> TestCases
    {
        get
        {
            yield return new TestCaseData(10).Returns(1);
            yield return new TestCaseData(99).Returns(18);
            yield return new TestCaseData(-32).Returns(5);
        }
    }

    [Test, TestCaseSource(nameof(TestCases))]
    public int FixedTest(int number) => SummingANumbersDigits.SumDigits(number);
}
