namespace CodeWars.Completed;

public static class AreThereDoubles
{
    public static bool DoubleCheck(string s)
    {
        for (int i = 1; i < s.Length; i++)
            if (string.Equals(
                s[i - 1].ToString(),
                s[i].ToString(),
                StringComparison.OrdinalIgnoreCase)
            )
                return true;

        return false;
    }
}