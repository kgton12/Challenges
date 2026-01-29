using CodeWars.Resolutions;

namespace CodeWarsTest.Completed;

public class MinmaxminBoundedNumsTest
{
    private static readonly object[] BasicTestCases =
        [
      new object[] {new int[] {-1, 4, 5, -23, 24}, new int[] {-23, -22, 24}},
      new object[] {new int[] {1, 3, -3, -2, 8, -1}, new int[] {-3, 0, 8}},
      new object[] {new int[] {2, -4, 8, -5, 9, 7}, new int[] {-5, -3, 9}},
        ];

    [Test, TestCaseSource(typeof(MinmaxminBoundedNumsTest), nameof(BasicTestCases))]
    public void BasicTest(int[] test, int[] expected)
    {
        Assert.That(MinmaxminBoundedNums.MinMinMax(test), Is.EqualTo(expected));
    }
}
