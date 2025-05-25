namespace BeeCrowd.src.Resolutions.Beginner;

public class Beecrowd1005
{
    public static void Average1()
    {
        double A = Convert.ToDouble(Console.ReadLine());
        double B = Convert.ToDouble(Console.ReadLine());

        var average = (A * 3.5 + B * 7.5) / 11;

        Console.WriteLine($"MEDIA = {average:F5}");
    }
}

