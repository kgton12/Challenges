using LeetCode.Completed;

namespace LeetCode.Test.Completed;

public class _231PowerOfTwoTest
{
    [Theory]
    [InlineData(1, true)]
    [InlineData(16, true)]
    [InlineData(3, false)]
    [InlineData(8, true)]
    [InlineData(2147483647, false)]
    public static void ValidParentheses_Should_Return_Correct_Values(int n, bool expected)
    {
        var result = _231PowerOfTwo.IsPowerOfTwo(n);

        Assert.Equal(expected, result);
    }
}
