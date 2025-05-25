namespace BeeCrowd.src.Resolutions.Beginner;

public class Beecrowd1014
{
    public static void Consumption()
    {
        int km = Convert.ToInt32(Console.ReadLine());
        double gas = Convert.ToDouble(Console.ReadLine());

        double media = Math.Round(km / gas, 3);

        Console.WriteLine($"{media:F3} km/l");
    }
}
