namespace CodeWars.Resolutions;

public class CountConsonants
{
    public static int ConsonantCount(string str) =>
        str
        .ToLower()
        .Count(x =>
            Enumerable.Range('a', 26)
            .Select(c => (char)c)
            .Where(c => !"aeiou".Contains(c)).Contains(x)
        );
}
