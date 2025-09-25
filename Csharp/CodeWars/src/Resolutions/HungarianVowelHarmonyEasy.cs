namespace CodeWars.src.Resolutions;

public class HungarianVowelHarmonyEasy
{
    public static string Dative(string word)
    {
        string frontVowels = "eéiíöőüű";
        string backVowels = "aáoóuú";

        for (int i = word.Length - 1; i >= 0; i--)
        {
            if (frontVowels.Contains(word[i])) return word + "nek";

            if (backVowels.Contains(word[i])) return word + "nak";
        }

        return string.Empty;
    }
}
