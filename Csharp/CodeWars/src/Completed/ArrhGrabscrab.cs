namespace CodeWars.Completed;

public class ArrhGrabscrab
{
    public static List<string> Grabscrab(string anagram, List<string> dictionary) =>
        [.. dictionary.Where(x => IsAnagram(anagram, x))];

    private static bool IsAnagram(string anagram, string word) =>
        anagram.OrderBy(x => x).SequenceEqual(word.OrderBy(x => x));
}