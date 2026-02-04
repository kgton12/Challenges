using CodeWars.Resolutions;

namespace CodeWarsTest.Completed;

public class InspiringStringsTest
{
    private static readonly object[] Basic_Test_Cases =
       [
      new object[] {"a b c d e fgh", "fgh"},
      new object[] {"one two three", "three"},
      new object[] {"red blue grey", "grey"},
       ];

    [Test, TestCaseSource(typeof(InspiringStringsTest), nameof(Basic_Test_Cases))]
    public void Basic_Test(string test, string expected)
    {
        Assert.That(InspiringStrings.LongestWord(test), Is.EqualTo(expected));
    }

}
