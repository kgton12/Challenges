namespace CodeWars.Completed;

public class CompleteThePattern5EvenLadder
{
    public static string Pattern(int n)
    {
        List<string> result = [];

        if (n <= 1)
            return string.Empty;

        for (int i = 2; i <= n; i++)
        {
            if (int.IsEvenInteger(i))
                result.Add(string.Concat(Enumerable.Repeat(i.ToString(), i)));
        }

        return string.Join("\n", result);
    }
}