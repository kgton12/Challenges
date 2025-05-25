namespace BeeCrowd.src.Resolutions.Beginner;

public class Beecrowd1133
{
    public static void RestOfDivision()
    {
        int first = Convert.ToInt32(Console.ReadLine());
        int second = Convert.ToInt32(Console.ReadLine());

        int start = Math.Min(first, second);
        int end = Math.Max(first, second);

        for (int i = start + 1; i < end; i++)
            if (i % 5 == 2 || i % 5 == 3)
                Console.WriteLine(i);
    }
}
