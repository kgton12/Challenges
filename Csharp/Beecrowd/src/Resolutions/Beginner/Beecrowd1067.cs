namespace BeeCrowd.src.Resolutions.Beginner;

public class Beecrowd1067
{
    public static void OddNumbers()
    {
        int n = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i <= n; i++)
        {
            if (i % 2 != 0) Console.WriteLine(i);
        }
    }
}
