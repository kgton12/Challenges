namespace CodeWars.Completed;

public class MonkeysMath01HowManyZeros
{
    public static int CountZero(string s)
    {
        Dictionary<char, int> zeroMap = new()
        {
            {'a', 1},
            {'b', 1},
            {'d', 1},
            {'e', 1},
            {'g', 1},
            {'o', 1},
            {'p', 1},
            {'q', 1},
            {'0', 1},
            {'6', 1},
            {'9', 1},
            {'%', 2},
            {'&', 2},
            {'B', 2},
            {'8', 2}
        };

        int count = 0;
        string word = s.ToLower().Replace("()", "0");

        foreach (var c in word)
        {
            if (zeroMap.TryGetValue(c, out int value))
                count += value;
        }

        return count;
    }
}