namespace BeeCrowd.src.Resolutions.Beginner;

public class Beecrowd1095
{
    public static void SequenceIJ1()
    {
        int i = 1;
        int value = 60;
        while (value >= 0)
        {
            Console.WriteLine($"I={i} J={value}");
            i += 3;
            value -= 5;
        }
    }
}
