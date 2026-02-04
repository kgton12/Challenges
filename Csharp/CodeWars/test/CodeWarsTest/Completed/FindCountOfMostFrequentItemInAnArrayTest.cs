using CodeWars.Resolutions;

namespace CodeWarsTest.Completed;

public class FindCountOfMostFrequentItemInAnArrayTest
{
    private static readonly object[] BasicTestCases =
    [
      new object[] {new int[] {3, -1, -1}, 2},
      new object[] {new int[] {3, -1, -1, -1, 2, 3, -1, 3, -1, 2, 4, 9, 3}, 5},
    ];

    [Test, TestCaseSource(typeof(FindCountOfMostFrequentItemInAnArrayTest), nameof(BasicTestCases)), Order(1)]
    public void Basic_Test(int[] test, int expected)
    {
        Assert.That(FindCountOfMostFrequentItemInAnArray.MostFrequentItemCount(test), Is.EqualTo(expected));
    }
}
