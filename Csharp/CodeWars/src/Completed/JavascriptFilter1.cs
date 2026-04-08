namespace CodeWars.Completed;

public static class JavascriptFilter1
{
    public static string[][] SearchNames(string[][] logins)
    {
        return [.. logins.Where(x => x.First().EndsWith('_'))];
    }
}
