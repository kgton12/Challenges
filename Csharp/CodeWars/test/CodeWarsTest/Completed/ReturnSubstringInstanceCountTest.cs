using CodeWars.Resolutions;

namespace CodeWarsTest.Completed;

public class ReturnSubstringInstanceCountTest
{
    private static IEnumerable<TestCaseData> TestCases
    {
        get
        {
            yield return new TestCaseData("abcdeb", "b").Returns(2);
            yield return new TestCaseData("abcdeb", "a").Returns(1);
            yield return new TestCaseData("ccddeeccddeecc", "cc").Returns(3);
        }
    }

    [Test, TestCaseSource(nameof(TestCases))]
    public int SampleTest(string fullText, string searchText) => ReturnSubstringInstanceCount.SubstringCount(fullText, searchText);
}
