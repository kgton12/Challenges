namespace CodeWars.Completed;

public class CountOfCodepointsInAUtf16String
{
    public static int GetRealLength(String str) =>
        str.EnumerateRunes().Count();
}
