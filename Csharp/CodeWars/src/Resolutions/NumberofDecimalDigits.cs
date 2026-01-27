namespace CodeWars.Resolutions;

public static class NumberofDecimalDigits
{
    public static int Digits(ulong n)
    {
        return n.ToString().Length;
    }
}

