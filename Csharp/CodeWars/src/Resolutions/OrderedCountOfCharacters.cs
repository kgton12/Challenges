namespace CodeWars.Resolutions;

public class OrderedCountOfCharacters
{
    public static List<Tuple<char, int>> OrderedCount(string input) =>
         [.. input
            .GroupBy(x => x)
            .Select(x => Tuple.Create(x.Key, x.Count()))
         ];
}
