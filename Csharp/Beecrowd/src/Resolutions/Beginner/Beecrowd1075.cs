namespace BeeCrowd.src.Resolutions.Beginner;

public class Beecrowd1075
{
    public static void Remainder2()
    {
        int n = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i < 1000; i++)
            if (i % n == 2) Console.WriteLine(i);
    }
}
