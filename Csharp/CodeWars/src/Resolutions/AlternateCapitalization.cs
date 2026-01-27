namespace CodeWars.Resolutions;

public class AlternateCapitalization
{
    public static string[] Capitalize(string s) =>
        [.. Enumerable
        .Range(0, 2)
        .Select(n =>
            string.Concat(
                s.Select((x, i) => i % 2 == n ? char.ToUpper(x) : x)))];
}
