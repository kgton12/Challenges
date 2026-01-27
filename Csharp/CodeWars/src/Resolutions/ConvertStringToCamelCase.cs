using System.Globalization;

namespace CodeWars.Resolutions;

public class ConvertStringToCamelCase
{
    public static string ToCamelCase(string str) =>
        string.Concat(str
            .Replace("-", " ")
            .Replace("_", " ")
            .Split(" ")
            .Select((x, i) => i == 0 ? x : CultureInfo.CurrentCulture.TextInfo.ToTitleCase(x))
        );
}
