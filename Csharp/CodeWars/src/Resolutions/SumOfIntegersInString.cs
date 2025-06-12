using System.Text.RegularExpressions;

namespace CodeWars.src.Resolutions;

public class SumOfIntegersInStringClass
{
    public static int SumOfIntegersInString(string s)
    {
        var matches = Regex.Matches(s, @"\d+");
        return matches
            .Sum(m => int.Parse(m.Value));
    }
}
