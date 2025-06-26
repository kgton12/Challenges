namespace CodeWars.src.Resolutions;

public static class StringArrayDuplicates
{
    public static string[] Dup(string[] arr)
    {
        List<string> result = [];

        foreach (var item in arr)
            result.Add(string.Concat(item.Where((_, index) => index == 0 || item[index] != item[index - 1])));

        return [.. result];
    }
}