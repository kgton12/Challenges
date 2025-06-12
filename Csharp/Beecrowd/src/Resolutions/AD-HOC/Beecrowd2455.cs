namespace BeeCrowd.src.Resolutions;

public class Beecrowd2455
{
    public static void Seesaw()
    {
        int[] lineValues = (Console.ReadLine() ?? string.Empty).Split(' ').Select(int.Parse).ToArray();

        int right = lineValues[0] * lineValues[1];
        int left = lineValues[2] * lineValues[3];

        if (right == left)
            Console.WriteLine("0");
        else if (right > left)
            Console.WriteLine("-1");
        else
            Console.WriteLine("1");
    }
}
