namespace BeeCrowd.src.Resolutions.Beginner;

public class Beecrowd1098
{
    public static void SequenceIJ4()
    {
        double i = 0;

        while (i <= 2)
        {
            Console.WriteLine($"I={Rounds(i)} J={Rounds(i + 1)}");
            Console.WriteLine($"I={Rounds(i)} J={Rounds(i + 2)}");
            Console.WriteLine($"I={Rounds(i)} J={Rounds(i + 3)}");
            i += 0.2;
        }
    }

    private static string Rounds(double n)
    {
        var rounded = Math.Round(n * 10) / 10;
        return rounded % 1 == 0 ? rounded.ToString() : $"{rounded:F1}";
    }
}