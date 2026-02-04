using CodeWars.Resolutions;

namespace CodeWarsTest.Completed;

public class IsogramsTest
{
    private static IEnumerable<TestCaseData> TestCases
    {
        get
        {
            yield return new TestCaseData("Dermatoglyphics").Returns(true);
            yield return new TestCaseData("isogram").Returns(true);
            yield return new TestCaseData("moose").Returns(false);
            yield return new TestCaseData("isIsogram").Returns(false);
            yield return new TestCaseData("aba").Returns(false);
            yield return new TestCaseData("moOse").Returns(false);
            yield return new TestCaseData("thumbscrewjapingly").Returns(true);
            yield return new TestCaseData("").Returns(true);
        }
    }

    [Test, TestCaseSource(nameof(TestCases))]
    public bool Test(string str) => Isograms.IsIsogram(str);
}
