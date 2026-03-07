namespace CodeWars.Resolutions;

public class TwiceLinear
{
    public static int DblLinear(int n)
    {
        int[] u = new int[n + 1];
        u[0] = 1;

        int i = 0;
        int j = 0;

        for (var k = 1; k <= n; k++)
        {
            int nextCandidate1 = 2 * u[i] + 1;
            int nextCandidate2 = 3 * u[j] + 1;
            int nextVal = Math.Min(nextCandidate1, nextCandidate2);
            u[k] = nextVal;
            if (nextVal == nextCandidate1) i++;
            if (nextVal == nextCandidate2) j++;
        }

        return u[n];
    }
}