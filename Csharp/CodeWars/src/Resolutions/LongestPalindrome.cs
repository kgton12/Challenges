namespace CodeWars.Resolutions;

public static class LongestPalindrome
{
    public static int GetLongestPalindrome(string? str)
    {
        int bigger = 0;

        if (string.IsNullOrEmpty(str)) return 0;

        for (int i = 0; i < str.Length; i++)
        {
            for (int j = i + 1; j <= str.Length; j++)
            {
                string substr = str[i..j];
                if (IsPalindrome(substr) && substr.Length > bigger)
                    bigger = substr.Length;
            }
        }

        return bigger;
    }

    private static bool IsPalindrome(string str) => str.Equals(new string([.. str.Reverse()]));
}
