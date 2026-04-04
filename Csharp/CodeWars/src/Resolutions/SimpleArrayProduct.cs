namespace CodeWars.Resolutions;

public class SimpleArrayProduct
{
    public static int Solve(int[][] arr)
    {
        long maxProd = arr[0].Max();
        long minProd = arr[0].Min();

        for (int i = 1; i < arr.Length; i++)
        {
            long nextMax = long.MinValue;
            long nextMin = long.MaxValue;

            foreach (int value in arr[i])
            {
                long a = maxProd * value;
                long b = minProd * value;

                if (a > nextMax) nextMax = a;
                if (b > nextMax) nextMax = b;

                if (a < nextMin) nextMin = a;
                if (b < nextMin) nextMin = b;
            }

            maxProd = nextMax;
            minProd = nextMin;
        }

        return (int)maxProd;
    }
}
