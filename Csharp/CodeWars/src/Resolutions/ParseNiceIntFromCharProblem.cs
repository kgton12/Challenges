using System.Text.RegularExpressions;

namespace CodeWars.Resolutions;

public class ParseNiceIntFromCharProblem
{
    public static int GetAge(string inputString) =>
        Convert.ToInt32(string.Concat(Regex.Replace(inputString, "[^0-9]", "")));
}
