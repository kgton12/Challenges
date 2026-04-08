namespace CodeWars.Completed;

public class TwoNumbersArePositive
{
    public static bool TwoArePositive(int a, int b, int c) =>
        new int[] { a, b, c }.Count(x => x > 0) == 2;
}
