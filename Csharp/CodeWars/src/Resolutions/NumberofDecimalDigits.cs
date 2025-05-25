namespace CodeWars.src.Resolutions;

internal class NumberofDecimalDigits
{
    public static int Digits(ulong n)
    {
        return n.ToString().Length;
    }
}

