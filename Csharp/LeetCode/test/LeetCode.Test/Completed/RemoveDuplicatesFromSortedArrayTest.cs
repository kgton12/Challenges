using LeetCode.Completed;

namespace LeetCode.Test.Completed;

public class RemoveDuplicatesFromSortedArrayTest
{
    [Theory]
    [InlineData(new int[] { 1, 1, 2 }, 2)]
    [InlineData(new int[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 }, 5)]
    public void RemoveDuplicatesFromSortedArray_Should_Return_Correct_Values(int[] nums, int expected)
    {
        var result = RemoveDuplicatesFromSortedArray.RemoveDuplicates(nums);

        Assert.Equal(expected, result);
    }
}