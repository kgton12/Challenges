using System.Text.RegularExpressions;

namespace CodeWars.Completed;

public class DetectPangram
{
    public static bool IsPangram(string str) =>
        Regex.Replace(str.ToLower(), "[^a-z]", string.Empty).Distinct().Count() == 26;
}
