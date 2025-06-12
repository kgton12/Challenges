namespace CodeWars.src.Resolutions;

public class SimpleStringCharacters
{
    public static int[] Solve(string s)
    {
        int upper = s.Count(char.IsUpper);
        int lower = s.Count(char.IsLower);
        int digits = s.Count(char.IsDigit);
        int special = s.Count(c => !char.IsLetterOrDigit(c) && !char.IsWhiteSpace(c));

        return [upper, lower, digits, special];
    }
}
