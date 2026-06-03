namespace LeetCode.Completed;

public class PalindromeNumber
{
    public static bool IsPalindrome(int x)
    {
        if (x < 0) return false;
        return x.ToString() == string.Concat(x.ToString().Reverse());
    }
}