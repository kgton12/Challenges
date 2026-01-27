namespace CodeWars.Resolutions;

public class CatYearsDogYears2
{
    public static (int, int) OwnedCatAndDog(int catYears, int dogYears) =>
        (
            ConvertToHumanYears(catYears, true), ConvertToHumanYears(dogYears, false)
        );

    private static int ConvertToHumanYears(int petYears, bool isCat)
    {
        if (petYears < 15) return 0;
        if (petYears < 24) return 1;

        int firstYear = 15;
        int secondYear = 9;
        int additionalYears = isCat ? 4 : 5;

        return 2 + (petYears - firstYear - secondYear) / additionalYears;
    }
}