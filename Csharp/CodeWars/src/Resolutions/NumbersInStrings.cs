using System.Text.RegularExpressions;

namespace CodeWars.src.Resolutions;

public class NumbersInStrings
{
    public static int Solve(string s) =>
        Regex
        .Replace(s, "[^0-9]", " ")
        .Split(" ", StringSplitOptions.RemoveEmptyEntries)
        .Max(Convert.ToInt32);
}
