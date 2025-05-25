namespace BeeCrowd.src;

public class Beecrowd1171
{
    public static void NumberFrequency()
    {
        int n = Convert.ToInt32(Console.ReadLine());
        int[] lineValues = new int[n];

        for (int i = 0; i < n; i++)
            lineValues[i] = Convert.ToInt32(Console.ReadLine());

        var frequency = lineValues
            .GroupBy(x => x)
            .Select(group => new { Key = group.Key, Value = group.Count() })
            .OrderBy(x => x.Key)
            .ToList();

        foreach (var item in frequency)
            Console.WriteLine($"{item.Key} aparece {item.Value} vez(es)");
    }
}
