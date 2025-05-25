namespace BeeCrowd.src.Resolutions.Beginner;

public class Beecrowd1073
{
    public static void SquareOfPairs()
    {
        int n = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            if (i % 2 == 0)
                Console.WriteLine($"{i}^2 = {Math.Pow(i, 2)}");
        }
    }
}
