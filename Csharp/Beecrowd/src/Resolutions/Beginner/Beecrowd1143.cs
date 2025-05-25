namespace BeeCrowd.src.Resolutions.Beginner;

public class Beecrowd1143
{
    public static void SquareAndCube()
    {
        int n = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= n; i++)
            Console.WriteLine($"{i} {Math.Pow(i, 2)} {Math.Pow(i, 3)}");
    }
}
