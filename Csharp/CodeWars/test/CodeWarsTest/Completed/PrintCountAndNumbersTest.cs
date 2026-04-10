using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class PrintCountAndNumbersTest
{
    private static IEnumerable<TestCaseData> TestCases
    {
        get
        {
            yield return new TestCaseData("1123").Returns("211213");
            yield return new TestCaseData("1").Returns("11");
            yield return new TestCaseData("a").Returns("");
            yield return new TestCaseData("11").Returns("21");
            yield return new TestCaseData("a123").Returns("");
            yield return new TestCaseData("21").Returns("1211");
            yield return new TestCaseData("1211").Returns("111221");
            yield return new TestCaseData("12322212223443").Returns("111213321132132413");
            yield return new TestCaseData("").Returns("");
            yield return new TestCaseData("123a").Returns("");
        }
    }

    [Test, TestCaseSource(nameof(TestCases))]
    public string Test(string data) => PrintCountAndNumbers.CountMe(data);
}