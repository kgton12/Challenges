namespace CodeWars.Resolutions;

public class Sillycase
{
    public static string SillyCase(string str) =>
        string.Concat(
            str.Select((n, i) => i < Math.Ceiling(str.Length / 2.0) ? char.ToLower(n) : char.ToUpper(n))
        );
}