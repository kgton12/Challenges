namespace CodeWars.Completed;

public class DuplicateEncoder
{
    public static string DuplicateEncode(string word) =>
        string.Concat(
            word.ToLower().Select(x => word.ToLower().Count(z => z == x) == 1 ? "(" : ")")
        );
}
