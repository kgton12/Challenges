namespace CodeWars.Resolutions;

public class RemoveFirstAndLastCharacter
{
    public static string RemoveChar(string s) =>
        s[1..^1];
}
