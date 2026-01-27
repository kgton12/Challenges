namespace CodeWars.Resolutions;

public class CompleteThePattern1
{
    public static string Pattern(int n) =>
        n < 1
        ? string.Empty
        : string.Join("\n",
            Enumerable
            .Range(1, n)
            .Select(x => string.Concat(
                Enumerable.Repeat(x.ToString(), x))
            )
        );
}
