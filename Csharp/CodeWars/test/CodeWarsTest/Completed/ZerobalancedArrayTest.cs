using CodeWars.Resolutions;

namespace CodeWarsTest.Completed;

public class ZerobalancedArrayTest
{
    private static void DoTest(List<int> arr, bool expected)
    {
        bool actual = ZerobalancedArray.IsZeroBalanced(arr);
        Assert.That(actual, Is.EqualTo(expected), $"Incorrect answer for array [{string.Join(", ", arr)}]");
    }

    [Test, Description("Sample tests")]
    [Order(1)]
    public void FixedTests()
    {
        ArraysWithZeroes();
        ArraysWithoutZeroes();
        NonZeroBalanced();
    }

    private static void ArraysWithZeroes()
    {
        DoTest([0, 0, 0, 0, 0, 0], true);
        DoTest([0, 1, -1], true);
        DoTest([0], true);
        DoTest([0, 0, 0, 0, 0], true);
    }

    private static void ArraysWithoutZeroes()
    {
        DoTest([1, -1, 2, -2], true);
        DoTest([3, -3, 5, -5, 7, -7], true);
    }

    private static void NonZeroBalanced()
    {
        DoTest([3], false);
        DoTest([-3], false);
        DoTest([], false);
        DoTest([3, -2, -1], false);
        DoTest([1, 1, -2], false);
        DoTest([-1, 1, -2, 2, -2, -2, -4, 4], false);
    }
}
