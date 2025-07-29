using System.Text.RegularExpressions;

namespace CodeWars.src.Resolutions;

public class HelpBobCountLettersAndDigits
{
    public static int CountLettersAndDigits(string input) =>
        Regex.Replace(input, "[^a-z0-9]", "", RegexOptions.IgnoreCase).Length;
}
