namespace CodeWars.Completed;

public static class BuildingStringsFromAHash
{
    public static string StringifyDict<TKey, TValue>(Dictionary<TKey, TValue> hash)
        where TKey : notnull
        => string.Join(",", [.. hash.Select(x => $"{x.Key} = {x.Value}")]);
}