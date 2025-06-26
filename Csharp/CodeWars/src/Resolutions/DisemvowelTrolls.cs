using System.Text.RegularExpressions;

namespace CodeWars.src.Resolutions;

public class DisemvowelTrolls
{
    public static string Disemvowel(string str) =>
        Regex.Replace(str, "[aeiou]", "", RegexOptions.IgnoreCase);
}
