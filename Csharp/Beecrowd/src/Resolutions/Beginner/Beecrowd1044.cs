namespace BeeCrowd.src.Resolutions.Beginner;

public class Beecrowd1044
{
    public static void Multiples()
    {
        int A, B;
        string[] inputLine = (Console.ReadLine() ?? string.Empty).Split(' ');
        A = Convert.ToInt32(inputLine[0]);
        B = Convert.ToInt32(inputLine[1]);

        if (B % A == 0 || A % B == 0)
            Console.WriteLine("Sao Multiplos");
        else
            Console.WriteLine("Nao sao Multiplos");
    }
}
