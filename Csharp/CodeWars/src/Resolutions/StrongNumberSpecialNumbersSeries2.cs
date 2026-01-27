namespace CodeWars.Resolutions;

public class StrongNumberSpecialNumbersSeries2
{
    public static string StrongNumber(int number) => number
         .ToString()
         .Sum(x =>
            Convert.ToInt32(
                CalculateFactorial((int)char.GetNumericValue(x))
            )) == number
        ? "STRONG!!!!"
        : "Not Strong !!";

    private static int CalculateFactorial(int N)
    {
        if (N == 0 || N == 1)
            return 1;

        int factorial = 1;
        for (int i = N; i > 1; i--)
            factorial *= i;

        return factorial;
    }
}
