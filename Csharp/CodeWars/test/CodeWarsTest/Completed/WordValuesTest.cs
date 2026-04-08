using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class WordValuesTest
{
    private static IEnumerable<TestCaseData> SampleTestCases
    {
        get
        {
            yield return new TestCaseData(new[] { new string[] { "codewars", "abc", "xyz" } }).Returns(new int[] { 88, 12, 225 });
            yield return new TestCaseData(new[] { new string[] { "abc abc", "abc abc", "abc", "abc" } }).Returns(new int[] { 12, 24, 18, 24 });
        }
    }

    [Test, TestCaseSource(nameof(SampleTestCases))]
    public int[] SampleTest(string[] a) => WordValues.WordValue(a);
}
