namespace BeeCrowd.src.Resolutions.Beginner;

public class Beecrowd1006
{
    public static void Average2()
    {
        double A = Convert.ToDouble(Console.ReadLine());
        double B = Convert.ToDouble(Console.ReadLine());
        double C = Convert.ToDouble(Console.ReadLine());

        double average = (A * 2 + B * 3 + C * 5) / 10;

        Console.WriteLine($"MEDIA = {average:F1}");
    }
}

