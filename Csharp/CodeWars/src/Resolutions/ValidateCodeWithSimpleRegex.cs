using System.Text.RegularExpressions;

namespace CodeWars.Resolutions;

public class ValidateCodeWithSimpleRegex
{
    public static bool ValidateCode(string code)
    {
        Regex regex = new("^[1-3]");
        return regex.IsMatch(code);
    }
}
