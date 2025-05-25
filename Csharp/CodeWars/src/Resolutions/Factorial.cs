namespace CodeWars.src.Resolutions;

public class FactorialClass
{
    public static int Factorial(int n)
    {
        if (n < 0 || n > 12) throw new ArgumentOutOfRangeException();

        if (n == 0 || n == 1)
            return 1;

        int factorial = 1;

        for (int i = n; i > 1; i--)
            factorial *= i;

        return factorial;
    }
}
