namespace CodeWars.Resolutions;

public class Contamination1String
{
    public static string Contamination(string text, string character)
    {
        return string.IsNullOrEmpty(character) ? string.Empty : new string(character[0], text.Length);
    }
}
