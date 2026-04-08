namespace CodeWars.Completed;

public class NameOnBillboard
{
    public static double Billboard(string name, double price = 30)
    {
        double sum = 0;

        foreach (var value in name)
        {
            sum += price;
        }

        return sum;
    }
}

