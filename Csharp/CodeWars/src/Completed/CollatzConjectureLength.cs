namespace CodeWars.Completed;

public class CollatzConjectureLength
{
    public static int Collatz(int n)
    {
        int result = 1;

        while (n != 1)
        {
            n = n % 2 == 0
                ? n / 2
                : (n * 3) + 1;
            result++;
        }

        return result;
    }
}
