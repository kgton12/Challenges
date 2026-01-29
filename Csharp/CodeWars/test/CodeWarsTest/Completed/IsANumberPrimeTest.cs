using CodeWars.Resolutions;

namespace CodeWarsTest.Completed;

public class IsANumberPrimeTest
{
    private static IEnumerable<TestCaseData> SampleTestCases
    {
        get
        {
            yield return new TestCaseData(0).Returns(false);
            yield return new TestCaseData(1).Returns(false);
            yield return new TestCaseData(2).Returns(true);
        }
    }

    [Test, TestCaseSource(nameof(SampleTestCases))]
    public bool SampleTest(int n) => IsANumberPrime.IsPrime(n);
}
