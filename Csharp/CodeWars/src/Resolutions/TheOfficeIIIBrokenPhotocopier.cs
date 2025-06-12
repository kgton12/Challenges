namespace CodeWars.src;

public class TheOfficeIIIBrokenPhotocopier
{
    public static string Broken(string x) => string.Join("", x.Select(x => x.Equals('0') ? '1' : '0'));
}
