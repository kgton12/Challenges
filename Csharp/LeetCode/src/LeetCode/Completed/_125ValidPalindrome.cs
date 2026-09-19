namespace LeetCode.Completed;

public class _125ValidPalindrome
{
    public static bool IsPalindrome(string s)
    {
        string sanitizedS = string.Concat(s.Where(x => char.IsAsciiLetter(x) || char.IsAsciiDigit(x)));

        return sanitizedS.Equals(string.Concat(sanitizedS.Reverse()), StringComparison.OrdinalIgnoreCase);
    }
}