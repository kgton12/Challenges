namespace BeeCrowd.src;

public class Beecrowd2454
{
    public static void Flipper()
    {
        string[] lineValues = (Console.ReadLine() ?? string.Empty).Split(' ');

        int A = Convert.ToInt32(lineValues[0]);
        int B = Convert.ToInt32(lineValues[1]);

        if (A == 0) Console.WriteLine("C");
        else if (A == 1 && B == 1) Console.WriteLine("A");
        else Console.WriteLine("B");
    }
}
