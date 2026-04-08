namespace CodeWars.Completed;

public static class UnscrambledEggs
{
    public static string UnscrambleEggs(string word) =>
        word.Replace("egg", "", StringComparison.OrdinalIgnoreCase);
}
