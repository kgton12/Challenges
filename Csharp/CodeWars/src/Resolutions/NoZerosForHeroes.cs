namespace CodeWars.Resolutions;

public class NoZerosForHeroes
{
    public static int NoBoringZeros(int n) =>
        n != 0 ? Convert.ToInt32(n.ToString().TrimEnd('0')) : 0;
}
