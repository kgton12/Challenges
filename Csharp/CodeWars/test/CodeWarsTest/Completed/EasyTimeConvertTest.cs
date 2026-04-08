using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class EasyTimeConvertTest
{
    private static IEnumerable<TestCaseData> TestCases
    {
        get
        {
            yield return new TestCaseData(0).Returns("00:00");
            yield return new TestCaseData(-6).Returns("00:00");
            yield return new TestCaseData(8).Returns("00:08");
            yield return new TestCaseData(32).Returns("00:32");
            yield return new TestCaseData(75).Returns("01:15");
            yield return new TestCaseData(63).Returns("01:03");
            yield return new TestCaseData(134).Returns("02:14");
            yield return new TestCaseData(180).Returns("03:00");
            yield return new TestCaseData(970).Returns("16:10");
            yield return new TestCaseData(565757).Returns("9429:17");
        }
    }

    [Test, TestCaseSource(nameof(TestCases))]
    public string Test(int num) =>
      EasyTimeConvert.TimeConvert(num);
}
