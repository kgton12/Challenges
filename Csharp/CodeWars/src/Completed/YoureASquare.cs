namespace CodeWars.Completed;

public class YoureASquare
{
    public static bool IsSquare(int n) =>
        double.IsInteger(Math.Sqrt(n));
}
