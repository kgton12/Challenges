namespace CodeWars.Completed;

public class HowManyStairsWillSuzukiClimbIn20Years
{
    public static long StairsIn20(int[][] stairs)
    {
        const int YEARS = 20;
        int total = stairs.Sum(week => week.Sum());
        return total * YEARS;
    }
}
