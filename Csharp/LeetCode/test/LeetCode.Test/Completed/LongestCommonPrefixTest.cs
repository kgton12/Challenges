using LeetCode.Completed;

namespace LeetCode.Test.Completed;

public class LongestCommonPrefixTest
{
    [Theory]
    [InlineData(new string[] { "flower", "flow", "flight" }, "fl")]
    [InlineData(new string[] { "dog", "racecar", "car" }, "")]
    public void LongestCommonPrefix_Should_Return_Correct_Values(string[] strs, string expected)
    {
        var result = LongestCommonPrefixClass.LongestCommonPrefix(strs);

        Assert.Equal(expected, result);
    }
}