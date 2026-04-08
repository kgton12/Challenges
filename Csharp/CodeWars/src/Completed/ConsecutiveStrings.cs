namespace CodeWars.Completed;

public class ConsecutiveStrings
{
    public static string LongestConsec(string[] strarr, int k)
    {
        if (strarr.Length == 0 || k > strarr.Length || k <= 0)
            return "";

        string longest = "";

        for (int i = 0; i <= strarr.Length - k; i++)
        {
            string concatStr = string.Concat(strarr.Skip(i).Take(k));

            if (concatStr.Length > longest.Length)
                longest = concatStr;
        }

        return longest;
    }
}
