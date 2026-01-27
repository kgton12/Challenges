using System.Globalization;

namespace CodeWars.Resolutions;

public static class JadenCasingStrings
{
    public static string ToJadenCase(this string phrase) =>
         CultureInfo.CurrentCulture.TextInfo.ToTitleCase(phrase);
}
