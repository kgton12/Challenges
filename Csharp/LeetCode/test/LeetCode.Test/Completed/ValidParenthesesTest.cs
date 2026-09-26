using LeetCode.Completed;

namespace LeetCode.Test.Completed;

public static class ValidParenthesesTest
{
    [Theory]
    [InlineData("()", true)]
    [InlineData("()[]{}", true)]
    [InlineData("(]", false)]
    [InlineData("([])", true)]
    [InlineData("([)]", false)]
    public static void ValidParentheses_Should_Return_Correct_Values(string s, bool expected)
    {
        var result = ValidParentheses.IsValid(s);

        Assert.Equal(expected, result);
    }
}
