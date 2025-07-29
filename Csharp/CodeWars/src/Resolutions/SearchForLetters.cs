namespace CodeWars.src.Resolutions;

public class SearchForLetters
{
    public static string Change(string input) =>
        string.Concat(
            Enumerable
            .Range('a', 26)
            .Select(x =>
                input
                .ToLower()
                .Contains((char)x)
                ? 1
                : 0
            )
        );
}
