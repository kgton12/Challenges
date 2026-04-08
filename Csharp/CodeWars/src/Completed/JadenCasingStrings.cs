using System.Globalization;

namespace CodeWars.Completed;

public static class JadenCasingStrings
{
    public static string ToJadenCase(this string phrase) =>
         CultureInfo.CurrentCulture.TextInfo.ToTitleCase(phrase);
}
