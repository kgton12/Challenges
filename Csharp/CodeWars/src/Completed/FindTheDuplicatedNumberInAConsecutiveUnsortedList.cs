namespace CodeWars.Completed;

public class FindTheDuplicatedNumberInAConsecutiveUnsortedList
{
    public static int FindDup(int[] arr)
    {
        return arr
            .GroupBy(x => x)
            .Select(x => new { x.Key, Count = x.Count() })
            .Where(x => x.Count > 1)
            .First().Key;
    }
}
