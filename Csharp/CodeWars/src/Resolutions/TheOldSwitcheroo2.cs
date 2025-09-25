namespace CodeWars.src.Resolutions;

public class TheOldSwitcheroo2
{
    public static string Encode(string str) =>
        string.Concat(
            str
            .ToLower()
            .Select(x => char.IsLetter(x) ? (x - 'a' + 1).ToString() : x.ToString())
        );
}
