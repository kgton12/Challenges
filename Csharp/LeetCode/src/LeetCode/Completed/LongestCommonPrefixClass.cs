namespace LeetCode.Completed;

public class LongestCommonPrefixClass
{
    public static string LongestCommonPrefix(string[] strs)
    {
        string shortestWord = strs.OrderBy(x => x.Length).First();

        if (shortestWord.Length == 0) return "";

        var result = string.Empty;

        for (int i = 0; i < shortestWord.Length; i++)
        {
            string chunk = shortestWord[..(i + 1)];

            if (strs.All(x => x.StartsWith(chunk))) result = chunk;
        }

        return result;
    }
}