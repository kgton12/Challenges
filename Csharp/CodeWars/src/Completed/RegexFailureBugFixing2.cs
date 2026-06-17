using System.Text.RegularExpressions;

namespace CodeWars.Completed;

public class RegexFailureBugFixing2
{
    public static string FilterWords(string phrase)
    {
        string pattern = @"\b(bad|mean|ugly|horrible|hideous)";
        string replacement = "awesome";
        Regex rgx = new(pattern, RegexOptions.IgnoreCase);

        return rgx.Replace(phrase, replacement);
    }
}