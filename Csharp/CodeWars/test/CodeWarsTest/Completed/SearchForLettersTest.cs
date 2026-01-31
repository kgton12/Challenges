using CodeWars.Resolutions;

namespace CodeWarsTest.Completed;

public class SearchForLettersTest
{
    private static IEnumerable<TestCaseData> TestCases
    {
        get
        {
            yield return new TestCaseData("a **&  bZ")
                                         .Returns("11000000000000000000000001");
            yield return new TestCaseData("!!a$%&RgTT")
                                         .Returns("10000010000000000101000000");
        }
    }

    [Test, TestCaseSource(nameof(TestCases))]
    public string Test(string input) => SearchForLetters.Change(input);
}
