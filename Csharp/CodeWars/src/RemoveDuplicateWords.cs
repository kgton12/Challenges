namespace CodeWars.src;

internal class RemoveDuplicateWordsClass
{
    public static string RemoveDuplicateWords(string s) =>
        string.Join(' ', s.Split(' ').Distinct());
}
