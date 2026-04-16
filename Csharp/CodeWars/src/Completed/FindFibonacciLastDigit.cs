namespace CodeWars.Completed;

public class FindFibonacciLastDigit
{
    public static int GetLastDigit(int index)
    {
        if (index == 0) return 0;
        if (index == 1) return 1;

        int a = 0, b = 1;
        for (int i = 2; i <= index; i++)
        {
            int c = (a + b) % 10;
            a = b;
            b = c;
        }
        return b;
    }
}
