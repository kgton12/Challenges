namespace CodeWars.src;

public class DigitsExplosion
{
    public static string Explode(string s) =>
        string.Concat(s.Select(x => new string(x, (int)char.GetNumericValue(x))));
}
