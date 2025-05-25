namespace BeeCrowd.src.Resolutions.Beginner;

public class Beecrowd1078
{
    public static void MultiplicationTables()
    {
        int n = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= 10; i++)
            Console.WriteLine($"{i} x {n} = {i * n}");
    }
}
