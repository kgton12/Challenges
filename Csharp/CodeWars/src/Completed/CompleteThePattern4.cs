namespace CodeWars.Completed;

public class CompleteThePattern4
{
    public static string Pattern(int n)
    {
        if (n <= 0) return string.Empty;

        var matriz = Enumerable.Range(1, n).ToList();
        List<string> result = [];

        foreach (var item in matriz)
            result.Add(string.Concat(Enumerable.Range(item, (n + 1) - item).ToArray()));

        return string.Join('\n', result);
    }
}
