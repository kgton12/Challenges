namespace CodeWars.src.Resolutions;

public static class BuildingStringsFromAHash
{
    public static string StringifyDict<TKey, TValue>(Dictionary<TKey, TValue> hash)
     => string.Join(",", [.. hash.Select(x => $"{x.Key} = {x.Value}")]);
}