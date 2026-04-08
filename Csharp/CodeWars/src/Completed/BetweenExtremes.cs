namespace CodeWars.Completed;

public class BetweenExtremesClass
{
    public static int BetweenExtremes(int[] numbers) =>
        Math.Abs(numbers.Max() - numbers.Min());
}
