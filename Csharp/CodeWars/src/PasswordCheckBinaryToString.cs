namespace CodeWars.src;

public class PasswordCheckBinaryToString
{
    public static string? DecodePass(string[] passArr, string bin)
    {
        var binStr = string.Concat(bin.Split(' ').Select(x => (char)Convert.ToInt32(x, 2)));
        return passArr.Contains(binStr) ? binStr : null;
    }
}