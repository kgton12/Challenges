using System.Text.RegularExpressions;

namespace CodeWars.Resolutions;

public class YourOrderPlease
{
    public static string Order(string words) =>
        string.Join(" ",
            words
            .Split(" ")
            .OrderBy(str => Regex.Replace(str, "[a-z]", "", RegexOptions.IgnoreCase))
        );
}
