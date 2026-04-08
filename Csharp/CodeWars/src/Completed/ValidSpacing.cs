namespace CodeWars.Completed;

public class ValidSpacingClass
{
    public static bool ValidSpacing(string s) => s == s.Trim() && !s.Trim().Contains("  ");
}
