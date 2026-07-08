namespace CodeWars.Completed;

public class NumberZooPatrol
{
    public static int FindNumber(int[] array)
    {
        HashSet<int> sortedNumbers = [.. array.OrderBy(x => x)];

        if (!sortedNumbers.TryGetValue(1, out _))
            return 1;

        foreach (var item in sortedNumbers)
        {
            if (!sortedNumbers.Contains(item + 1))
                return item + 1;
        }

        return -1;
    }
}