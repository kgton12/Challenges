using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class SortNumbersClassTest
{
    [Test]
    public void BasicTests()
    {
        CheckNums([1, 2, 3, 10, 5], [1, 2, 3, 5, 10]);
        CheckNums(null, []);
        CheckNums([], []);
        CheckNums([20, 2, 10], [2, 10, 20]);
        CheckNums([2, 20, 10], [2, 10, 20]);
        CheckNums([2, 10, 20], [2, 10, 20]);
    }

    private static void CheckNums(int[]? nums, int[] expected)
    {
        var actual = SortNumbersClass.SortNumbers(nums);

        Assert.That(actual, Is.EqualTo(expected), nums != null ? "{" + string.Join(",", nums) + "}" : "null");
    }
}
