using System.Text.RegularExpressions;

namespace CodeWars.Completed;

public class ExclamationMarksSeries11ReplaceAllVowelToExclamationMarkInTheSentence
{
    public static string Replace(string s)
    {
        var regex = new Regex("[aeiou]", RegexOptions.IgnoreCase);

        return regex.Replace(s, "!");
    }
}

