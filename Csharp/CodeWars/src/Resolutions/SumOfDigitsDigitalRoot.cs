namespace CodeWars.src.Resolutions;

public class SumOfDigitsDigitalRoot
{
    public static int DigitalRoot(long n)
    {
        if (n == 0) return 0;
        int mod = (int)(n % 9);
        return mod == 0 ? 9 : mod;
    }
}
