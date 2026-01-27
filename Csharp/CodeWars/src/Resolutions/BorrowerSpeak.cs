namespace CodeWars.Resolutions;

public class BorrowerSpeak
{
    public static string Borrow(string s) =>
        string.Concat(s.Where(char.IsAsciiLetter).Select(char.ToLower));
}
