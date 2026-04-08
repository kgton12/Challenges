namespace CodeWars.Completed;

public class NumbersToLetters
{
    public static string Switcher(string[] x)
    {
        Dictionary<string, string> specialMappings = new()
        {
            { "27", "!" },
            { "28", "?" },
            { "29", " " }
        };

        var output = string.Concat(x.Select(x =>
        {
            if (specialMappings.TryGetValue(x, out string? value))
                return value;
            else
                return ((char)('a' + (26 - Convert.ToInt32(x)))).ToString();
        }));

        return output;
    }
}
