namespace BeeCrowd.src.Resolutions.Beginner;

public class Becrowd1015
{
    public static void DistanceBetweenTwoPoints()
    {
        string[] line1 = (Console.ReadLine() ?? string.Empty).Split(' ');
        string[] line2 = (Console.ReadLine() ?? string.Empty).Split(' ');

        double x1, x2, y1, y2;

        x1 = Convert.ToInt32(line1[0]);
        y1 = Convert.ToInt32(line1[1]);

        x2 = Convert.ToInt32(line2[0]);
        y2 = Convert.ToInt32(line2[1]);

        double result = Math.Round(Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2)), 4);

        Console.WriteLine($"{result:F4}");
    }
}
