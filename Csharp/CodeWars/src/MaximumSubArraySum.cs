namespace CodeWars.src;

public class MaximumSubArraySum
{
    public static int MaxSequence(int[] arr)
    {
        if (arr.Length == 0) return 0;

        List<int> result = [];
        for (int i = 0; i < arr.Length; i++)
            for (int j = i; j < arr.Length; j++)
                result.Add(arr.Skip(i).Take(j).Sum());

        return result.Max();
    }
}
