using System.Text.RegularExpressions;

namespace CodeWars.src.Resolutions;

public class SumOfABeachClass
{
    public static int SumOfABeach(string s) =>
        new Regex("(sand|water|sun|fish)", RegexOptions.IgnoreCase).Matches(s).Count;
}