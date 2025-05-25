namespace BeeCrowd.src.Resolutions.Beginner;

public class Beecrowd1060
{
    public static void PositiveNumbers()
    {
        double[] linha =
        [
            Convert.ToDouble(Console.ReadLine()),
            Convert.ToDouble(Console.ReadLine()),
            Convert.ToDouble(Console.ReadLine()),
            Convert.ToDouble(Console.ReadLine()),
            Convert.ToDouble(Console.ReadLine()),
            Convert.ToDouble(Console.ReadLine()),
        ];

        int positiveCount = 0;

        for (int i = 0; i < linha.Length; i++)
        {
            if (linha[i] >= 0)
                positiveCount++;
        }

        Console.WriteLine($"{positiveCount} valores positivos");
    }
}
