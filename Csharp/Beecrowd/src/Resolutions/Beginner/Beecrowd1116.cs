namespace BeeCrowd.src.Resolutions.Beginner;

public class Beecrowd1116
{
    public static void DividingXbyY()
    {
        int n = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            int[] lineValues = (Console.ReadLine() ?? string.Empty).Split(' ').Select(value => Convert.ToInt32(value)).ToArray();
            int x = lineValues[0];
            int y = lineValues[1];

            if (y == 0)
                Console.WriteLine("divisao impossivel");
            else if (x == 0)
                Console.WriteLine("0.0");
            else
                Console.WriteLine($"{(double)x / y:F1}");
        }
    }
}
