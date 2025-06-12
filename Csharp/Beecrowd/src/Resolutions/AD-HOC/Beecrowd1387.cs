namespace BeeCrowd.src;

public class Beecrowd1387
{
    public static void Og()
    {
        while (true)
        {
            string[] lineValues = (Console.ReadLine() ?? string.Empty).Split(' ');
            int A = Convert.ToInt32(lineValues[0]);
            int B = Convert.ToInt32(lineValues[1]);

            if (A == 0 && B == 0) break;

            Console.WriteLine(A + B);
        }
    }
}
