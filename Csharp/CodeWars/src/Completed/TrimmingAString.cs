namespace CodeWars.Completed;

public class TrimmingAString
{
    public static string TrimString(string phrase, int len)
    {
        return (phrase.Length <= len, len > 3) switch
        {
            (true, _) => phrase,
            (false, true) => phrase[..(len - 3)] + "...",
            (false, false) => phrase[..len] + "..."
        };
    }
}
