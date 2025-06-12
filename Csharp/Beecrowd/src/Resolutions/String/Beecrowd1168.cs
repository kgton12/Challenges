namespace BeeCrowd.src.Resolutions.String;

public class Beecrowd1168
{
    public static void LED()
    {
        Dictionary<char, int> led = new Dictionary<char, int>
        {
            { '1', 2 },
            { '2', 5 },
            { '3', 5 },
            { '4', 4 },
            { '5', 5 },
            { '6', 6 },
            { '7', 3 },
            { '8', 7 },
            { '9', 6 },
            { '0', 6 }
        };

        int N = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < N; i++)
        {
            string valueLine = Console.ReadLine() ?? string.Empty;
            int ledCount = valueLine.Select(x => led[x]).Sum();
            Console.WriteLine($"{ledCount} leds");
        }
    }
}
