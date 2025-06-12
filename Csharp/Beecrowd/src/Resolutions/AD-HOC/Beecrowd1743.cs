namespace BeeCrowd.src.Resolutions;

public class Beecrowd1743
{
    public static void AutomatedVerificationMachine()
    {
        int[] plug = (Console.ReadLine() ?? string.Empty).Trim().Split(' ').Select(int.Parse).ToArray();
        int[] socket = (Console.ReadLine() ?? string.Empty).Trim().Split(' ').Select(int.Parse).ToArray();
        bool isCompatible = true;

        for (int i = 0; i < 5; i++)
            if (plug[i] == socket[i]) isCompatible = false;

        Console.WriteLine(isCompatible ? "Y" : "N");
    }
}
