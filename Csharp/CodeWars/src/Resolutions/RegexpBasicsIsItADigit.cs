using System.Text.RegularExpressions;

namespace CodeWars.src.Resolutions;

public static class RegexpBasicsIsItADigit
{
    public static bool Digit(this string s) =>
        s.Length == 1
        && Regex.Replace(s, "[0-9]", "").Count() == 0;
}
