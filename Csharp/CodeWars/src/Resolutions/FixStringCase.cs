namespace CodeWars.src.Resolutions;

public class FixStringCase
{
    public static string Solve(string s) =>
        s.Count(char.IsUpper) > s.Length / 2 ? s.ToUpper() : s.ToLower();
}
