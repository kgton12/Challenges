namespace CodeWars.src.Resolutions;

public class SpoonerizeMe
{
    public static string Spoonerize(string str)
    {
        string[] words = str.Split(' ');
        var firstWord = words[1][0] + words[0][1..];
        var secondWord = words[0][0] + words[1][1..];

        return $"{firstWord} {secondWord}";
    }
}
