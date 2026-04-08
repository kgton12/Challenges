namespace CodeWars.Completed;

public class ReplaceWithAlphabetPosition
{
    public static string AlphabetPosition(string text) =>
        string.Join(" ",
            text
            .ToLower()
            .Where(char.IsLetter)
            .Select(x => x - 'a' + 1));
}
