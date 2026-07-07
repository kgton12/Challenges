namespace CodeWars.Completed;

public class AreWeAlternate
{
    private static readonly char[] vowels = ['a', 'e', 'i', 'o', 'u',];

    public static bool IsAlt(string word)
    {
        for (int i = 1; i < word.Length; i++)
        {
            if (IsVowel(word[i]) == IsVowel(word[i - 1]))
                return false;
        }

        return true;
    }

    private static bool IsVowel(char c)
    {
        return vowels.Contains(c);
    }
}