using System.Text.RegularExpressions;

namespace CodeWars.Resolutions;

public class RegexCountLowercaseLetters
{
    public static int LowercaseCountCheck(string s) => Regex.Matches(s, "[a-z]").Count;
}
