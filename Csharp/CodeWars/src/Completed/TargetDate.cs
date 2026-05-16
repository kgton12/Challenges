namespace CodeWars.Completed;

public class TargetDate
{
    public static string DateNbDays(double a0, double a, double p)
    {
        double dailyRate = p / 36000;
        int days = 0;

        while (a0 < a)
        {
            a0 += (dailyRate * a0);
            days++;
        }

        return new DateTime(2016, 01, 01).AddDays(days).ToString("yyyy-MM-dd");
    }
}
