namespace CodeWars.src.Resolutions;

public class SortByLastChar
{
    public static string[] Last(string x) => [.. x.Split(' ').OrderBy(x => x.Last())];
}
