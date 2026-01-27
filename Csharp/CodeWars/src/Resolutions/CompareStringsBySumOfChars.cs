using System.Text.RegularExpressions;

namespace CodeWars.Resolutions;

public class CompareStringsBySumOfChars
{
    public static bool Compare(string s1, string s2) =>
        SumOfAsciiValues(s1) == SumOfAsciiValues(s2);

    private static int SumOfAsciiValues(string? str)
    {
        if (string.IsNullOrEmpty(str) || Regex.Match(str, "[^a-z]", RegexOptions.IgnoreCase).Success)
            return 0;

        return str.ToUpper().Sum(Convert.ToInt32);
    }
}
