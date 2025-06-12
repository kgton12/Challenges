using System.Text.RegularExpressions;

namespace CodeWars.src.Resolutions;

public class StringCleaning
{
    public static string StringClean(string s) => Regex.Replace(s, "[0-9]", "");
}
