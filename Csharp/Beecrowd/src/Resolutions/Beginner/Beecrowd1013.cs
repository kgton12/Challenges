namespace BeeCrowd.src.Resolutions.Beginner;

public class Beecrowd1013
{
    public static void TheGreatest()
    {
        string[] line = (Console.ReadLine() ?? string.Empty).Split(' ');

        int A, B, C, greatestAB, greatest;
        A = Convert.ToInt32(line[0]);
        B = Convert.ToInt32(line[1]);
        C = Convert.ToInt32(line[2]);

        greatestAB = (A + B + Math.Abs(A - B)) / 2;
        greatest = greatestAB > C ? greatestAB : C;

        Console.WriteLine($"{greatest} eh o maior");
    }
}
