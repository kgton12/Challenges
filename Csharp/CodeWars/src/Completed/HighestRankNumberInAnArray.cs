namespace CodeWars.Completed;

public class HighestRankNumberInAnArray
{
    public static int HighestRank(int[] arr)
    {
        var grouped = arr.GroupBy(x => x)
                         .Select(g => new { Number = g.Key, Count = g.Count() });

        var highestRank = grouped.OrderByDescending(g => g.Count)
                                 .ThenByDescending(g => g.Number)
                                 .FirstOrDefault();

        return highestRank?.Number ?? 0;
    }
}
