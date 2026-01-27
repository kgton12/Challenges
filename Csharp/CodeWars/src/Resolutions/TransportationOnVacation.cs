namespace CodeWars.Resolutions;

public class TransportationOnVacation
{
    public static int RentalCarCost(int d)
    {
        int discount = 0;
        int dailyValue = 40;

        if (d >= 3 && d < 7) discount = 20;
        if (d >= 7) discount = 50;

        return d * dailyValue - discount;
    }
}
