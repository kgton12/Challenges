namespace CodeWars.Completed;

public class DeodorantEvaporator
{
    public static int Evaporator(double content, double evap_per_day, double threshold)
    {
        int quantityOfDays = 0;
        double percentThreshold = content * threshold / 100;

        while (content > percentThreshold)
        {
            content -= content * evap_per_day / 100;

            quantityOfDays++;
        }

        return quantityOfDays;
    }
}
