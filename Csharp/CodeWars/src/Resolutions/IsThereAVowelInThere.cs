namespace CodeWars.Resolutions;

public class IsThereAVowelInThere
{
    public static object[] IsVow(object[] a)
    {
        Dictionary<int, string> vowel = new()
        {
            { 97, "a" },
            { 101, "e" },
            { 105, "i" },
            { 111, "o" },
            { 117, "u" }
        };

        return [.. a.Select(item =>
        {
            if (vowel.TryGetValue(Convert.ToInt32(item), out string? vowelChar))
                return vowelChar;

            return item;
        })];
    }
}
