namespace CodeWars.Resolutions;

public class FindTheRemainder
{
    public static int Remainder(int a, int b)
    {
        if (Math.Min(a, b) == 0) throw new DivideByZeroException();

        return Math.Max(a, b) % Math.Min(a, b);
    }
}
