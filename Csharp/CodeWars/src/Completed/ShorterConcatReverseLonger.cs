namespace CodeWars.Completed;

public class ShorterConcatReverseLonger
{
    public static string ShorterReverseLonger(string a, string b)
    {
        a ??= string.Empty;
        b ??= string.Empty;

        string shorter, longer;

        if (a.Length == b.Length)
        {
            shorter = b;
            longer = a;
        }
        else if (a.Length < b.Length)
        {
            shorter = a;
            longer = b;
        }
        else
        {
            shorter = b;
            longer = a;
        }

        string reversedLonger = new([.. longer.Reverse()]);
        return $"{shorter}{reversedLonger}{shorter}";
    }
}
