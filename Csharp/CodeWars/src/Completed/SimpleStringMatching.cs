namespace CodeWars.Completed;

public static class SimpleStringMatching
{
    public static bool Solve(string a, string b)
    {
        string[] splitedString = a.Split('*', StringSplitOptions.RemoveEmptyEntries);

        if (splitedString.Length == 0)
            return true;

        if (splitedString.Length == 1)
        {
            if (a[0].Equals('*'))
                return b.EndsWith(splitedString[0]);
            else
                return b.StartsWith(splitedString[0]);
        }

        return b.EndsWith(splitedString[1]);
    }
}
