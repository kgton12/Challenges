namespace CodeWars.Completed;

public class TakeTheDerivative
{
    public static string Derive(double coefficient, double exponent) =>
        $"{coefficient * exponent}x^{exponent - 1}";
}
