namespace CodeWars.Resolutions;

public class DeleteOccurrencesOfAnElementIfItOccursMoreThanNTimes
{
    public static int[] DeleteNth(int[] arr, int x)
    {
        var occurrences = new Dictionary<int, int>();
        var result = new List<int>(arr.Length);

        foreach (var item in arr)
        {
            occurrences.TryGetValue(item, out int count);
            if (count < x)
            {
                result.Add(item);
                occurrences[item] = count + 1;
            }
        }

        return [.. result];
    }
}
