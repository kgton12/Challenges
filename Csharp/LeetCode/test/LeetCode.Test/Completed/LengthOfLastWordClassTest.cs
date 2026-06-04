using LeetCode.Completed;

namespace LeetCode.Test.Completed;

public class LengthOfLastWordClassTest
{
    [Theory]
    [InlineData("Hello World", 5)]
    [InlineData("   fly me   to   the moon  ", 4)]
    [InlineData("luffy is still joyboy", 6)]
    public void LengthOfLastWordClass_Should_Return_Correct_Values(string s, int expected)
    {
        var result = LengthOfLastWordClass.LengthOfLastWord(s);

        Assert.Equal(expected, result);
    }
}
