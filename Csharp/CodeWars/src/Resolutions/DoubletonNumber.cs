namespace CodeWars.Resolutions;

public class DoubletonNumber
{
    public static int Doubleton(int num)
    {
        int i = num + 1;
        while (!IsDoubletonNumber(i))
            i++;

        return i;
    }

    private static bool IsDoubletonNumber(int n) =>
        n.ToString().Distinct().Count() == 2;
}