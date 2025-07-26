namespace CodeWars.src.Resolutions;

public class EvensAndOddsClass
{
    public static string EvensAndOdds(int num) =>
        num % 2 == 0 ? Convert.ToString(num, 2) : Convert.ToString(num, 16);
}
