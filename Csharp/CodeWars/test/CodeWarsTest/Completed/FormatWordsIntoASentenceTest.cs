using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class FormatWordsIntoASentenceTest
{
    private static IEnumerable<TestCaseData> TestCases
    {
        get
        {
            yield return new TestCaseData([new string[] { "one", "two", "three", "four" }])
                             .Returns("one, two, three and four")
                             .SetDescription("{\"one\", \"two\", \"three\", \"four\"} should return \"one, two, three and four\"");

            yield return new TestCaseData([new string[] { "one" }])
                             .Returns("one")
                             .SetDescription("{\"one\"} should return \"one\"");

            yield return new TestCaseData([new string[] { "one", "", "three" }])
                             .Returns("one and three")
                             .SetDescription("{\"one\", \"\", \"three\"} should return \"one and three\"");

            yield return new TestCaseData([new string[] { "", "", "three" }])
                             .Returns("three")
                             .SetDescription("{\"\", \"\", \"three\"} should return \"three\"");

            yield return new TestCaseData([new string[] { "one", "two", "" }])
                             .Returns("one and two")
                             .SetDescription("{\"one\", \"two\", \"\"} should return \"one and two\"");

            yield return new TestCaseData([new string[] { }])
                             .Returns("")
                             .SetDescription("{} should return \"\"");

            yield return new TestCaseData(null)
                             .Returns("")
                             .SetDescription("null should return \"\"");

            yield return new TestCaseData([new string[] { "" }])
                             .Returns("")
                             .SetDescription("{\"\"} should return \"\"");
        }
    }

    [Test, TestCaseSource(nameof(TestCases))]
    public string Test(string[] words) => FormatWordsIntoASentence.FormatWords(words);
}
