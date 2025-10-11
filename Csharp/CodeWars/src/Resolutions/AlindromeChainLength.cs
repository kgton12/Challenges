namespace CodeWars.src.Resolutions;

internal class AlindromeChainLength
{
    public static int PalindromeChainLength(int n)
    {
        int count = 0;
        long sum = n;

        while (true)
        {
            if (IsPalindrome(sum))
                break;

            sum += ReverseNumber(sum);
            count++;
        }

        return count;
    }

    private static bool IsPalindrome(long n) =>
        n.ToString().Equals(
            string.Concat(n.ToString().Reverse())
        );

    private static long ReverseNumber(long n) =>
        Convert.ToInt64(string.Concat(n.ToString().Reverse()));
}
