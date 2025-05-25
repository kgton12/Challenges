namespace BeeCrowd.src;

public class Beecrowd1329
{
    public static void HeadsOrTails()
    {
        while (true)
        {
            var playCount = Convert.ToInt32(Console.ReadLine());

            if (playCount == 0) break;

            int[] gameResults = (Console.ReadLine() ?? string.Empty).Split(' ').Select(x => Convert.ToInt32(x)).ToArray();

            int maryPoints = gameResults.Count(c => c == 0);
            int johnPoints = gameResults.Count(c => c == 1);

            Console.WriteLine($"Mary won {maryPoints} times and John won {johnPoints} times");
        }
    }
}
