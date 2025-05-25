namespace BeeCrowd.src.Resolutions.Beginner;

public class Beecrowd1132
{
    public static void MultiplesOf13()
    {
        int first = Convert.ToInt32(Console.ReadLine());
        int second = Convert.ToInt32(Console.ReadLine());

        int x = Math.Min(first, second);
        int y = Math.Max(first, second);
        int sum = 0;

        for (int i = x; i <= y; i++)
            sum += i % 13 != 0 ? i : 0;

        Console.WriteLine(sum);
    }
}
