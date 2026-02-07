namespace CodeWars.Resolutions;

public static class SumsOfParts
{
    public static int[] PartsSums(int[] ls)
    {
        int sum = ls.Sum();
        List<int> result = [];
        result.Add(sum);

        foreach (var item in ls)
        {
            sum -= item;
            result.Add(sum);
        }

        return [.. result];
    }
}
