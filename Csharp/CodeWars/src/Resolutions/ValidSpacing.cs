namespace CodeWars.src.Resolutions;

public class ValidSpacingClass
{
    public static bool ValidSpacing(string s) => s == s.Trim() && !s.Trim().Contains("  ");
}
