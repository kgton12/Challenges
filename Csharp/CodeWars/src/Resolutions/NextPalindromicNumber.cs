namespace CodeWars.src.Resolutions;

public class NextPalindromicNumber
{
    public static int NextPal(int val)
    {
        int palindrome = val;
        while (true)
        {
            palindrome++;
            if (IsPalindrome(palindrome))
                return palindrome;
        }
    }

    private static bool IsPalindrome(int n) =>
        n == Convert.ToInt32(string.Concat(n.ToString().Reverse()));
}
