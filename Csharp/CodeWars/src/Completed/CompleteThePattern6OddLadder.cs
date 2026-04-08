namespace CodeWars.Completed;

public class CompleteThePattern6OddLadder
{
    public static string OddLadder(int n)
    {
        List<string> result = [];

        for (int i = 1; i <= n; i += 2)
        {
            result.Add(
                string.Concat(Enumerable.Repeat(i, i))
                );
        }

        return string.Join('\n', result);
    }
}