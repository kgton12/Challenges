namespace CodeWars.Completed;

public class PageReplacementAlgorithmsFifo
{
    public static List<int> Fifo(int n, List<int> referenceList)
    {
        int previousNum = -1;
        int[] result = [.. Enumerable.Repeat(-1, n)];
        int index = 0;

        foreach (var num in referenceList)
        {
            if (previousNum != num && !result.Contains(num))
            {
                result[index] = num;

                if (index == n - 1)
                    index = 0;
                else
                    index++;

                previousNum = num;
            }
        }

        return [.. result];
    }
}