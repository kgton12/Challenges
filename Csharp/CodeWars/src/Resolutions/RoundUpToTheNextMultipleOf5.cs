namespace CodeWars.src.Resolutions;

public class RoundUpToTheNextMultipleOf5
{
    public static int RoundToNext5(int n) => Convert.ToInt32(5 * Math.Ceiling(n / 5.0));
}
