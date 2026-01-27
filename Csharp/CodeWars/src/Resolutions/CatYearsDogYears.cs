namespace CodeWars.Resolutions;

public class CatYearsDogYears
{
    public static int[] HumanYearsCatYearsDogYears(int humanYears)
    {
        return [CalculateYears(humanYears, "human"),
                CalculateYears(humanYears, "cat"),
                CalculateYears(humanYears, "dog")];
    }

    private static int CalculateYears(int humanYears, string species)
    {
        if (species.Equals("human")) return humanYears;

        int multiplicator = species.Equals("cat") ? 4 : 5;
        int[] initialAge = [15, 9];

        int[] ages = [.. initialAge.Concat(Enumerable.Repeat(multiplicator, humanYears))];

        return ages.Take(humanYears).Sum();
    }
}
