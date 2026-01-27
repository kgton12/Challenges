namespace CodeWars.Resolutions;

public class UniqueStringCharacters
{
    public static string Solve(string a, string b)
    {
        var setA = new HashSet<char>(a);
        var setB = new HashSet<char>(b);

        var result = new List<char>();

        foreach (var letter in a)
            if (!setB.Contains(letter)) result.Add(letter);

        foreach (var letter in b)
            if (!setA.Contains(letter)) result.Add(letter);

        return string.Concat(result);
    }
}
