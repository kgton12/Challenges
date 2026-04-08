namespace CodeWars.Completed;

public class ShortLongShort
{
    public static string Solution(string a, string b)
    {
        string shortString = a.Length > b.Length ? b : a;
        string longString = b.Length > a.Length ? b : a;

        return shortString + longString + shortString;
    }
}
