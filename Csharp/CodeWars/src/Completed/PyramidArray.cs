namespace CodeWars.Completed;

public class PyramidArray
{
    public static int[][] Pyramid(int n)
    {
        var result = new List<int[]>();

        for (int i = 1; i <= n; i++)
            result.Add([.. Enumerable.Repeat(1, i)]);

        return [.. result];
    }
}
