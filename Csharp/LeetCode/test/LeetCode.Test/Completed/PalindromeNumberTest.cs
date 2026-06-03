using LeetCode.Completed;

namespace LeetCode.Test.Completed;

public class PalindromeNumberTest
{
    [Theory]
    [InlineData(121, true)]
    [InlineData(-121, false)]
    [InlineData(10, false)]

    public void PalindromeNumber_Should_Return_Correct_Values(int x, bool expected)
    {
        var result = PalindromeNumber.IsPalindrome(x);

        Assert.Equal(expected, result);
    }
}