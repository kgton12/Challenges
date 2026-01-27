namespace CodeWars.Resolutions;

public class AnagramDetection
{
    public static bool IsAnagram(string a, string b)
    {
        var aOrdered = new string([.. a.ToLower().OrderBy(x => x)]);
        var bOrdered = new string([.. b.ToLower().OrderBy(x => x)]);

        return aOrdered == bOrdered;
    }
}
