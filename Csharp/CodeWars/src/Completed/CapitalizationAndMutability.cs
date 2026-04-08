using System.Globalization;

namespace CodeWars.Completed;

public class CapitalizationAndMutability
{
    public static string CapitalizeWord(string word) =>
        CultureInfo.CurrentCulture.TextInfo.ToTitleCase(word.ToLower());
}
