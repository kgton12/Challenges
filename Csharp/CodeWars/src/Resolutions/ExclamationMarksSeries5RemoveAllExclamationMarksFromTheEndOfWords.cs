namespace CodeWars.Resolutions;

public class ExclamationMarksSeries5RemoveAllExclamationMarksFromTheEndOfWords
{
    public static string Remove(string s) =>
        string.Join(" ", s.Split(' ').Select(x => x.TrimEnd('!')));
}