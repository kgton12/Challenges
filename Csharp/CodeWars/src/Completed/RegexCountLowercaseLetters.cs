using System.Text.RegularExpressions;

namespace CodeWars.Completed;

public class RegexCountLowercaseLetters
{
    public static int LowercaseCountCheck(string s) => Regex.Matches(s, "[a-z]").Count;
}
