using System.Text.RegularExpressions;

namespace CodeWars.Resolutions;

public class TheOldSwitcheroo
{
    public static string Vowel2Index(string str) => Regex.Replace(str, "[aeiouAEIOU]", x => (x.Index + 1).ToString());
}
