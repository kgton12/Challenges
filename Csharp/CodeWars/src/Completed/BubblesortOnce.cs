namespace CodeWars.Completed;

public class BubblesortOnce
{
    public static int[] BubbleSortOnce(int[] input)
    {
        int[] result = [.. input];

        for (int i = 1; i < result.Length; i++)
        {
            if (result[i - 1] > result[i])
                (result[i - 1], result[i]) = (result[i], result[i - 1]);
        }

        return result;
    }
}
