using System.Globalization;

namespace CodeWars.Completed;

public class Mumbling
{
    public static string Accum(string s) =>
        string.Join("-",
            s.ToLower()
            .Select(
                (value, index) => CultureInfo.CurrentCulture.TextInfo.ToTitleCase(new string(value, index + 1))
            )
        );
}
