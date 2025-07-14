using System.Globalization;

namespace CodeWars.src.Resolutions;

public class CapitalizationAndMutability
{
    public static string CapitalizeWord(string word) =>
        CultureInfo.CurrentCulture.TextInfo.ToTitleCase(word.ToLower());
}
