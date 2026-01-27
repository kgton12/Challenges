namespace CodeWars.Resolutions;

public class GrowthOfAPopulation
{
    public static int NbYear(int p0, double percent, int aug, int p)
    {
        int years = 0;
        int newPopulation = p0;

        while (newPopulation < p)
        {
            years++;
            newPopulation = CalculatePopulation(newPopulation, percent, aug);
        }

        return years;
    }
    private static int CalculatePopulation(int p0, double percent, int aug) =>
        (int)Math.Floor(p0 + p0 * percent / 100 + aug);
}
