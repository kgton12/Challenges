namespace CodeWars.src.Resolutions;

public class DifferenceBetweenYearsLevel1
{
    public static int HowManyYears(string date1, string date2) =>
        Math.Abs(Convert.ToDateTime(date1).Year - Convert.ToDateTime(date2).Year);
}
