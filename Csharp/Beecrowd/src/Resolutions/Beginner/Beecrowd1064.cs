namespace BeeCrowd.src.Resolutions.Beginner;

public class Beecrowd1064
{
    public static void PositivesAndAverage()
    {
        List<double> sum = [];

        for (int i = 0; i < 6; i++)
        {
            var n = Convert.ToDouble(Console.ReadLine());

            if (n > 0.0) sum.Add(n);
        }

        Console.WriteLine("{0} valores positivos", sum.Count);
        Console.WriteLine("{0:f1}", sum.Average());
    }
}
