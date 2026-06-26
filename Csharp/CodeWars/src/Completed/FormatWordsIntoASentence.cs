namespace CodeWars.Completed;

public class FormatWordsIntoASentence
{
    public static string FormatWords(string[] words)
    {
        string[]? itens = words?
                    .Where(w => !string.IsNullOrEmpty(w))
                    .ToArray();

        if (itens is null)
            return string.Empty;

        return itens.Length switch
        {
            0 => string.Empty,
            1 => itens[0],
            _ => string.Join(", ", itens[..^1]) + " and " + itens[^1]
        };
    }
}