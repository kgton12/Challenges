namespace CodeWars.src.Resolutions;

public class HeronsFormula
{
    public static double Heron(int a, int b, int c)
    {
        double s = (a + b + c) / 2.0;
        return Math.Sqrt(s * (s - a) * (s - b) * (s - c));
    }
}
