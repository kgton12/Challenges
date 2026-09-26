namespace LeetCode.Test.Completed;

public class _217ContainsDuplicateTest
{
    [Theory]
    [InlineData(new int[] { 1, 2, 3, 1 }, true)]
    [InlineData(new int[] { 1, 2, 3, 4 }, false)]
    [InlineData(new int[] { 1, 1, 1, 3, 3, 4, 3, 2, 4, 2 }, true)]
    public static void ValidParentheses_Should_Return_Correct_Values(int[] n, bool expected)
    {
        var result = _217ContainsDuplicate.ContainsDuplicate(n);

        Assert.Equal(expected, result);
    }
}
