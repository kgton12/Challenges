using LeetCode.Completed;

namespace LeetCode.Test.Completed;

public class SearchInsertPositionTest
{
    [Theory]
    [InlineData(new int[] { 1, 3, 5, 6 }, 5, 2)]
    [InlineData(new int[] { 1, 3, 5, 6 }, 2, 1)]
    [InlineData(new int[] { 1, 3, 5, 6 }, 7, 4)]
    public void SearchInsertPosition_Should_Return_Correct_Values(int[] nums, int target, int expected)
    {
        var result = SearchInsertPosition.SearchInsert(nums, target);

        Assert.Equal(expected, result);
    }
}
