using CodeWars.Resolutions;

namespace CodeWarsTest.Completed;

public class OddevenStringSortTest
{
    private static readonly object[] testCases =
        [
          new object[] {"CodeWars", "CdWr oeas"},
          new object[] {"YCOLUE'VREER", "YOU'RE CLEVER"},
        ];

    [Test, TestCaseSource(nameof(testCases))]
    public void Test(string s, string expected) => Assert.That(OddevenStringSort.SortMyString(s), Is.EqualTo(expected));
}
