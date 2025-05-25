namespace CodeWars.src.Resolutions;

public class ReversingWordsInAString
{
    public static string Reverse(string text)
    {
        return string.Join(" ", text.Split(" ").Reverse());
    }
}
