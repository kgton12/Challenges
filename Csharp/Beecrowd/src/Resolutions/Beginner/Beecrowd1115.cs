namespace BeeCrowd.src.Resolutions.Beginner;

public class Beecrowd1115
{
    public static void Quadrant()
    {
        while (true)
        {
            int[] quadrants = (Console.ReadLine() ?? string.Empty).Split(' ').Select(v => Convert.ToInt32(v)).ToArray();

            int x = quadrants[0];
            int y = quadrants[1];

            if (x > 0 && y > 0)
                Console.WriteLine("primeiro");
            else if (x > 0 && y < 0)
                Console.WriteLine("quarto");
            else if (x < 0 && y < 0)
                Console.WriteLine("terceiro");
            else if (x < 0 && y > 0)
                Console.WriteLine("segundo");
            else if (x == 0 || y == 0)
                break;
        }
    }
}