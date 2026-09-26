namespace LeetCode.Completed;

public class _202HappyNumber
{
    public static bool IsHappy(int n)
    {
        HashSet<int> vistos = [];

        while (n != 1 && !vistos.Contains(n))
        {
            vistos.Add(n);
            n = SumOfSquaresOfDigits(n);
        }

        return n == 1;
    }

    private static int SumOfSquaresOfDigits(int n) =>
        (int)n.ToString().Sum(x => Math.Pow(char.GetNumericValue(x), 2));
}