namespace BeeCrowd.src.Resolutions.Beginner;

public class Beecrowd1096
{
    public static void SequenceIJ2()
    {
        for (int i = 1; i <= 9; i += 2)
            for (int j = 7; j >= 5; j--)
                Console.WriteLine($"I={i} J={j}");
    }
}
