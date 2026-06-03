using LeetCode.Completed;

namespace LeetCode.Test.Completed;

public class TwoSumTest
{
    [Theory]
    [InlineData(new int[] { 2, 7, 11, 15 }, 9, new int[] { 0, 1 })]
    [InlineData(new int[] { 3, 2, 4 }, 6, new int[] { 1, 2 })]
    [InlineData(new int[] { 3, 3 }, 6, new int[] { 0, 1 })]
    public void TwoSum_Should_Return_Correct_Values(int[] nums, int target, int[] expected)
    {
        var result = TwoSumClass.TwoSum(nums, target);

        Assert.Equal(expected, result);
    }
}