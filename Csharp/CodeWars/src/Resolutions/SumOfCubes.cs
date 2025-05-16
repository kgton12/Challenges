namespace CodeWars.src.Resolutions;

public class SumOfCubes
{
    public static long SumCubes(int n)
    {
        long sum = 0;

        for (int i = 1; i <= n; i++)
            sum += (long)Math.Pow(i, 3);

        return sum;
    }
}

