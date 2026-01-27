namespace CodeWars.Resolutions;

public static class RegexpBasicsIsItAVowel
{
    public static bool Vowel(this string s) => "aeiou".Contains(s, StringComparison.InvariantCultureIgnoreCase) && s.Length == 1;
}
