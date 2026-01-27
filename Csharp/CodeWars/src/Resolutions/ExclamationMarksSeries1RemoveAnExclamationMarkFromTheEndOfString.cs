namespace CodeWars.Resolutions;

public class ExclamationMarksSeries1RemoveAnExclamationMarkFromTheEndOfString
{
    public static string Remove(string s) =>
        s.EndsWith('!') ? string.Concat(s.Take(s.Length - 1)) : s;
}
