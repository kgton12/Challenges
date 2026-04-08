namespace CodeWars.Completed;

public class ANeedleInTheHaystack
{
    public static string FindNeedle(object[] haystack) =>
        $"found the needle at position {Array.IndexOf(haystack, "needle")}";
}
