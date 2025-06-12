using System.Text.RegularExpressions;

namespace CodeWars.src.Resolutions;

public class RegexCountLowercaseLetters
{
    public static int LowercaseCountCheck(string s) => Regex.Matches(s, "[a-z]").Count;
}
