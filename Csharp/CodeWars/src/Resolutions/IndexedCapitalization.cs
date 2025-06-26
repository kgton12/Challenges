namespace CodeWars.src.Resolutions;

public static class IndexedCapitalization
{
    public static string Capitalize(string s, List<int> idxs) =>
        string.Concat(s.Select((c, index) => idxs.Contains(index) ? char.ToUpper(c) : c));
}

