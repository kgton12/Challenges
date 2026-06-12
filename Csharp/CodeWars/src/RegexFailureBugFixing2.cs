using System.Text.RegularExpressions;

namespace CodeWars;

public class RegexFailureBugFixing2
{
    public static string FilterWords(string phrase)
    {
        string pattern = @"bad\b|mean\b|ugly\b|horrible\b|hideous\b";
        string replacement = "awesome";
        Regex rgx = new(pattern, RegexOptions.IgnoreCase);
        return rgx.Replace(phrase, replacement);
    }
}
