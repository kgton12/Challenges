namespace CodeWars.Completed;

public class BasicEncryption
{
    public static string Encrypt(string text, int rule)
    {
        return string.Concat(
            text.Select(character =>
                (char)((character + rule) % 256)
            )
        );
    }
}