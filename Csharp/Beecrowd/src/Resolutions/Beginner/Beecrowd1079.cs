namespace BeeCrowd.src.Resolutions.Beginner;

public class Beecrowd1079
{
    public static void WeightedAverages()
    {
        int n = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            var inputValues = (Console.ReadLine() ?? string.Empty).Split(' ').Select(Convert.ToDouble).ToArray();

            double average = (inputValues[0] * 2 + inputValues[1] * 3 + inputValues[2] * 5) / 10;

            Console.WriteLine($"{average:F1}");
        }
    }
}
