using System.Text.RegularExpressions;

namespace CodeWars.Completed;

public class DisemvowelTrolls
{
    public static string Disemvowel(string str) =>
        Regex.Replace(str, "[aeiou]", "", RegexOptions.IgnoreCase);
}
