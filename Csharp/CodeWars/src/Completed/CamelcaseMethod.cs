using System.Globalization;

namespace CodeWars.Completed;

public static class CamelcaseMethod
{
    public static string CamelCase(this string str) =>
        string.Concat(str.Split(" ").Select(CultureInfo.CurrentCulture.TextInfo.ToTitleCase));
}
