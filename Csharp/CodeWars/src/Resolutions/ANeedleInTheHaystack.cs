namespace CodeWars.src.Resolutions;

public class ANeedleInTheHaystack
{
    public static string FindNeedle(object[] haystack) =>
        $"found the needle at position {Array.IndexOf(haystack, "needle")}";
}
