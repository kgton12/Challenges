namespace CodeWars.Completed;

public class BuildASquare
{
    public static string GenerateShape(int n) =>
        string.Join(Environment.NewLine, Enumerable.Repeat(new string('+', n), n));
}
