namespace CodeWars.src.Resolutions;

public class FindTheCapitals
{
    public static int[] Capitals(string word) =>
        [.. word
        .Select((value, index) => new { value, index })
        .Where(x => char.IsUpper(x.value))
        .Select(x => x.index)];
}


