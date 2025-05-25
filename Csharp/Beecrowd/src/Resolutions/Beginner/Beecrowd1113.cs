namespace BeeCrowd.src.Resolutions.Beginner;

public class Beecrowd1113
{
    public static void AscendingAndDescending()
    {
        while (true)
        {
            int[] lineValues = (Console.ReadLine() ?? string.Empty).Split(' ').Select(x => Convert.ToInt32(x)).ToArray();

            if (lineValues[0] == lineValues[1])
                break;
            else if (lineValues[0] < lineValues[1])
                Console.WriteLine("Crescente");
            else
                Console.WriteLine("Decrescente");
        }
    }
}
