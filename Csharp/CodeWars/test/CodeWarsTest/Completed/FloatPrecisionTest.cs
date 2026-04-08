using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class FloatPrecisionTest
{
    private static IEnumerable<TestCaseData> TestCases
    {
        get
        {
            yield return new TestCaseData(2.34).Returns(2.34);
            yield return new TestCaseData(5.678).Returns(5.68);
        }
    }

    [Test, TestCaseSource(nameof(TestCases))]
    public double FixedTest(double n) => FloatPrecision.Round(n);
}
