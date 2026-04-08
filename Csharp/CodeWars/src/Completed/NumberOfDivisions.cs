namespace CodeWars.Completed;

public class NumberOfDivisions
{
    public static int Divisions(int n, int divisor)
    {
        if (divisor <= 1 || n < divisor) return 0;

        int count = 0;

        while (n >= divisor)
        {
            n /= divisor;
            count++;
        }

        return count;
    }
}
// version with Math.
// public static int Divisions(int n, int divisor) => (int) Math.Log(n, div);