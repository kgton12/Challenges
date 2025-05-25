namespace BeeCrowd.src.Resolutions.Beginner;

public class Beecrowd1144
{
    public static void LogicalSequence()
    {
        int n = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine($"{i} {Math.Pow(i, 2)} {Math.Pow(i, 3)}");
            Console.WriteLine($"{i} {Math.Pow(i, 2) + 1} {Math.Pow(i, 3) + 1}");
        }
    }
}
