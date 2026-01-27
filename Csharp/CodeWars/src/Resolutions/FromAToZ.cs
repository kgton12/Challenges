namespace CodeWars.Resolutions;

public class FromAToZ
{
    public static string GimmeTheLetters(string sp) =>
        string.Concat(
            Enumerable
            .Range(sp[0], sp[2] - sp[0] + 1)
            .Select(x => (char)x)
        );
}
