namespace BeeCrowd.src.Resolutions;

public class Beecrowd2456
{
    public static void Letters()
    {
        int[] lineValues = (Console.ReadLine() ?? string.Empty).Split(' ').Select(int.Parse).ToArray();

        int[] orderedValues = lineValues.OrderBy(x => x).ToArray();
        int[] descendingValues = lineValues.OrderByDescending(x => x).ToArray();

        if (lineValues.SequenceEqual(orderedValues))
            Console.WriteLine("C");
        else if (lineValues.SequenceEqual(descendingValues))
            Console.WriteLine("D");
        else
            Console.WriteLine("N");
    }
}
