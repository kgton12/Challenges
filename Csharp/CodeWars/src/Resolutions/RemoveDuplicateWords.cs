namespace CodeWars.Resolutions;

public class RemoveDuplicateWordsClass
{
    public static string RemoveDuplicateWords(string s) =>
        string.Join(' ', s.Split(' ').Distinct());
}
