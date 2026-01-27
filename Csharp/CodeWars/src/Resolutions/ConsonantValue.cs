namespace CodeWars.Resolutions;

public class ConsonantValue
{
    public static int Solve(string s)
    {
        int currentSum = 0;
        int maxSum = 0;

        foreach (char ch in s.ToLower())
        {
            if (IsVowel(ch))
            {
                if (currentSum > 0)
                {
                    maxSum = Math.Max(maxSum, currentSum);
                    currentSum = 0;
                }
            }
            else if (char.IsLetter(ch))
                currentSum += AlphabetPosition(ch);
        }

        if (currentSum > 0)
            maxSum = Math.Max(maxSum, currentSum);

        return maxSum;
    }
    private static bool IsVowel(char c) =>
        "aeiou".Contains(c);

    private static int AlphabetPosition(char c) =>
        c - 'a' + 1;
}
