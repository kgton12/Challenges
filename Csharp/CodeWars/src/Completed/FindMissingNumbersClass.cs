namespace CodeWars.Completed;

public class FindMissingNumbersClass
{
    public static int[] FindMissingNumbers(int[] arr)
    {
        if (arr.Length == 0)
            return [];

        (int min, int max) = (arr.Min(), arr.Max());
        List<int> result = [];

        for (int i = min + 1; i < max; i++)
        {
            if (!arr.Contains(i))
                result.Add(i);
        }

        return result.Count != 0
            ? [.. result]
            : [];
    }
}
