namespace CodeWars.src.Resolutions;

public class EmailAddressObfuscator
{
    public static string Obfuscate(string email) =>
        email.Replace("@", " [at] ").Replace(".", " [dot] ");
}