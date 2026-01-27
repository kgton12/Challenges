namespace CodeWars.Resolutions;

public class FindTheVowels
{
    private static readonly string vowels = "aeiouy";
    public static int[] VowelIndices(string word) =>
        [.. word
        .ToLower()
        .Select((value, index) => new { value, index = index + 1 })
        .Where(x => vowels.Contains(x.value))
        .Select(x => x.index)];
}


