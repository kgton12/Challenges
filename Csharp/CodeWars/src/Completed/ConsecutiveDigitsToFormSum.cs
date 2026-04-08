namespace CodeWars.Completed;

public class ConsecutiveDigitsToFormSum
{
    public static bool ConsecutiveDucks(int n) =>
        (n & (n - 1)) != 0;
}