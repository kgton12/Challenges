namespace CodeWars.Completed;

public class PowersOf3
{
    public static int LargestPower(int n)
    {
        for (int i = 0; i < n; i++)
        {
            if (Math.Pow(3, i) >= n)
                return i - 1;
        }

        return -1;
    }
}