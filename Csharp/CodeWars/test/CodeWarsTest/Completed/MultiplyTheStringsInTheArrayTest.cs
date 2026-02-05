using CodeWars.Resolutions;

namespace CodeWarsTest.Completed;

public class MultiplyTheStringsInTheArrayTest
{
    private static IEnumerable<TestCaseData> TestCases
    {
        get
        {
            yield return new TestCaseData(new[] { new string[] { "4", "5" } }).Returns("20");
            yield return new TestCaseData(new[] { new string[] { "2", "-5" } }).Returns("-10");
            yield return new TestCaseData(new[] { new string[] { "9", "0" } }).Returns("0");
        }
    }

    [Test, TestCaseSource(nameof(TestCases))]
    public string Test(string[] arr) =>
      MultiplyTheStringsInTheArray.ArrMultiply(arr);
}
