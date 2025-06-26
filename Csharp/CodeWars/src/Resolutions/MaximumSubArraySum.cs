namespace CodeWars.src.Resolutions;

public class MaximumSubArraySum
{
    public static int MaxSequence(int[] arr)
    {
        int maxSoFar = 0;
        int maxEndingHere = 0;

        foreach (var value in arr)
        {
            maxEndingHere = Math.Max(0, maxEndingHere + value);
            maxSoFar = Math.Max(maxSoFar, maxEndingHere);
        }

        return maxSoFar;
    }
}
