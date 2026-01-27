namespace CodeWars.Resolutions;

public class NumberPairs
{
    public static int[] GetLargerNumbers(int[] a, int[] b)
    {
        int[] result = new int[a.Length];

        for (int i = 0; i < a.Length; i++)
            result[i] = Math.Max(a[i], b[i]);
        return result;
    }
}
