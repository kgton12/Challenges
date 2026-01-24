using System.Text.RegularExpressions;

namespace CodeWars.src.Resolutions;

public class FindTheCombination
{
    public static int CountCombinations(string text, string key)
    {
        Regex regex = new(key, RegexOptions.IgnoreCase);
        return regex.Count(text);
    }
}
