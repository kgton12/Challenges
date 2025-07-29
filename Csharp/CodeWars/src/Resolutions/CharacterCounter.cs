namespace CodeWars.src.Resolutions;

public class CharacterCounter
{
    public static bool ValidateWord(string s)
    {
        var charCounts = s
            .ToLowerInvariant()
            .GroupBy(x => x)
            .Select(x => new { x.Key, Value = x.Count() });

        return charCounts.All(x => x.Value == charCounts.First().Value);
    }
}
