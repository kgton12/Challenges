using LeetCode.Completed;

namespace LeetCode.Test.Completed;

public class RemoveElementClassTest
{
    [Theory]
    [InlineData(new int[] { 3, 2, 2, 3 }, 3, 2)]
    [InlineData(new int[] { 0, 1, 2, 2, 3, 0, 4, 2 }, 2, 5)]
    public void RemoveElement_Should_Return_Correct_Values(int[] nums, int target, int expected)
    {
        var result = RemoveElementClass.RemoveElement(nums, target);

        Assert.Equal(expected, result);
    }
}
