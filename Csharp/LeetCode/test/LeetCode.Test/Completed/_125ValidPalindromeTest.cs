using LeetCode.Completed;

namespace LeetCode.Test.Completed;


public static class _125ValidPalindromeTest
{
    [Theory]
    [InlineData("A man, a plan, a canal: Panama", true)]
    [InlineData("race a car", false)]
    [InlineData(" ", true)]
    [InlineData("0P", false)]
    public static void ValidPalindrome(string s, bool expected)
    {
        var result = _125ValidPalindrome.IsPalindrome(s);

        Assert.Equal(expected, result);
    }
}