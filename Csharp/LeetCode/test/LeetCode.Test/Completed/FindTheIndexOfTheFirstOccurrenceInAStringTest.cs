using LeetCode.Completed;

namespace LeetCode.Test.Completed;

public class FindTheIndexOfTheFirstOccurrenceInAStringTest
{
    [Theory]
    [InlineData("sadbutsad", "sad", 0)]
    [InlineData("leetcode", "leeto", -1)]
    public void FindTheIndexOfTheFirstOccurrenceInAString_Should_Return_Correct_Values(string haystack, string needle, int expected)
    {
        var result = FindTheIndexOfTheFirstOccurrenceInAString.StrStr(haystack, needle);

        Assert.Equal(expected, result);
    }
}
