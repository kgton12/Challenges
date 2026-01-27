namespace CodeWars.Resolutions;

public class CommonSubstrings
{
    public static bool SubstringTest(string str1, string str2)
    {
        str1 = str1.ToLower();
        str2 = str2.ToLower();

        string smaller = str1.Length <= str2.Length ? str1 : str2;
        string bigger = str1.Length > str2.Length ? str1 : str2;

        for (int len = 2; len <= smaller.Length; len++)
        {
            for (int i = 0; i <= smaller.Length - len; i++)
            {
                string sub = smaller.Substring(i, len);
                if (bigger.Contains(sub))
                    return true;
            }
        }
        return false;
    }
}