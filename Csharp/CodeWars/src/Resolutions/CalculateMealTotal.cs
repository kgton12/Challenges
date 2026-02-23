namespace CodeWars.Resolutions;

public class CalculateMealTotal
{
    public static double CalculateTotal(double subtotal, int tax, int tip) =>
        Math.Round(
            subtotal + CalculatePercentage(subtotal, tax) + CalculatePercentage(subtotal, tip)
        , 2);

    private static double CalculatePercentage(double subtotal, int perc) =>
        subtotal * perc / 100;
}
