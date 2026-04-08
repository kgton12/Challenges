namespace CodeWars.Completed;

public class ConsecutiveLetters
{
    public static bool Solve(string s)
    {
        if (s.Length != s.Distinct().Count()) return false;

        var sortedS = string.Concat(s.OrderBy(x => x));

        for (int i = 1; i < s.Length; i++)
        {
            if (sortedS[i - 1] + 1 == sortedS[i]) continue;
            else
                return false;
        }
        return true;
    }
}