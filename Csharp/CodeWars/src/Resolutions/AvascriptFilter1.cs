namespace CodeWars.src.Resolutions;

public class AvascriptFilter1
{
    public static string[][] SearchNames(string[][] logins)
    {
        return [.. logins.Where(x => x.First().EndsWith('_'))];
    }
}
