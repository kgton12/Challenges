namespace BeeCrowd.src.Resolutions.Beginner;

public class Beecrowd1041
{
    public static void CoordinatesOfaPoint()
    {
        double y, x;
        string[] input = (Console.ReadLine() ?? string.Empty).Split(' ');
        x = Convert.ToDouble(input[0]);
        y = Convert.ToDouble(input[1]);

        if (x + y == 0)
            Console.WriteLine("Origem");
        else if (x == 0)
            Console.WriteLine("Eixo Y");
        else if (y == 0)
            Console.WriteLine("Eixo X");
        else if (x > 0 && y > 0)
            Console.WriteLine("Q1");
        else if (x > 0 && y < 0)
            Console.WriteLine("Q4");
        else if (x < 0 && y > 0)
            Console.WriteLine("Q2");
        else if (x < 0 && y < 0)
            Console.WriteLine("Q3");
    }
}
