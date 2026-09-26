using LeetCode.Completed;

namespace LeetCode.Test.Completed;

public class _202HappyNumberTest
{
    [Theory]
    [InlineData(19, true)]
    [InlineData(2, false)]
    [InlineData(1111111, true)]
    public static void ValidParentheses_Should_Return_Correct_Values(int n, bool expected)
    {
        var result = _202HappyNumber.IsHappy(n);

        Assert.Equal(expected, result);
    }
}