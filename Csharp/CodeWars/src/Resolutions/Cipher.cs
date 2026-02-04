namespace CodeWars.Resolutions;

public static class Cipher
{
    public static string Encode(string str)
    {
        return string.Concat(str.Select(x => Convert.ToChar(x * 6)));
    }

    public static string Decode(string str)
    {
        return string.Concat(str.Select(x => Convert.ToChar(x / 6)));
    }
}
