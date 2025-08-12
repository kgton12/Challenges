namespace CodeWars.src.Resolutions;

public class LookingForABenefactor
{
    public static long NewAvg(double[] arr, double navg)
    {
        double currentSum = arr.Sum();
        double requiredTotal = navg * (arr.Length + 1);

        if (currentSum >= requiredTotal) throw new ArgumentException();

        return (long)Math.Ceiling(requiredTotal - currentSum);
    }
}
