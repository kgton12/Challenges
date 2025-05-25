namespace BeeCrowd.src.Resolutions.Beginner;

public class Beecrowd1017
{
    public static void FuelConsumption()
    {
        int timeSpent = Convert.ToInt32(Console.ReadLine());
        int AverageSpeed = Convert.ToInt32(Console.ReadLine());

        double liters = timeSpent * AverageSpeed / 12.0;

        Console.WriteLine($"{liters:F3}");
    }
}
