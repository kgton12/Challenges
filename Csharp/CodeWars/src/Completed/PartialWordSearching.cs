namespace CodeWars.Completed;

public static class PartialWordSearching
{
    public static string[] WordSearch(string query, string[] seq) =>
        [.. seq.Where(x => x.Contains(query, StringComparison.OrdinalIgnoreCase)).DefaultIfEmpty("Empty")];
}
