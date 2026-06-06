namespace CodeWars.Completed;

public class CompleteThePattern2
{
    public static string Pattern(int n)
    {
        return n < 1
            ? string.Empty
            : string.Join(
                '\n',
                Enumerable.Range(1, n).Select(x => CreateSequential(x, n))
            );
    }

    private static string CreateSequential(int initial, int final)
    {
        return string.Concat(
            Enumerable
                .Range(initial, final - initial + 1)
                .Reverse()
                .Select(i => i.ToString())
                .ToArray()
         );
    }
}