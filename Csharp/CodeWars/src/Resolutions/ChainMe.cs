namespace CodeWars.src;

public class ChainMe
{
    public static double Chain(double input, Func<double, double>[] fs)
    {
        double result = input;
        foreach (var f in fs)
        {
            result = f(result);
        }
        return result;
    }
}
