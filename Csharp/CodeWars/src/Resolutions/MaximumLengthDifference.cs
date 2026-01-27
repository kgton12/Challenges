namespace CodeWars.Resolutions;

public class MaximumLengthDifference
{
    public static int Mxdiflg(string[] a1, string[] a2)
    {
        if (a1.Length == 0 || a2.Length == 0) return -1;

        int[] a1Lengths = [.. a1.Select((s) => s.Length)];
        int[] a2Lengths = [.. a2.Select((s) => s.Length)];

        int maxA1 = a1Lengths.Max();
        int minA1 = a1Lengths.Min();
        int maxA2 = a2Lengths.Max();
        int minA2 = a2Lengths.Min();

        return Math.Max(Math.Abs(maxA1 - minA2), Math.Abs(maxA2 - minA1));
    }
}
