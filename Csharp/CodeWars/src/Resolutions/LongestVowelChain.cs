namespace CodeWars.src.Resolutions;

public class LongestVowelChain
{
    public static int Solve(string str)
    {
        string vowels = "aeiou";
        int result = 0;
        int count = 0;

        foreach (var item in str.ToLower())
        {
            if (vowels.Contains(item))
                count++;
            else
            {
                result = Math.Max(result, count);
                count = 0;
            }
        }

        return Math.Max(result, count);
    }
}