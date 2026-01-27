namespace CodeWars.Resolutions;

public static class WordValues
{
    public static int[] WordValue(string[] words) => [.. words.Select((word, index) => WordSum(word) * (index + 1))];

    private static int WordSum(string word) => word.ToLowerInvariant().Where(char.IsLetter).Sum(c => c - 'a' + 1);
}
