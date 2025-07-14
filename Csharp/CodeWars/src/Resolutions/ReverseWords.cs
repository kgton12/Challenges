namespace CodeWars.src.Resolutions;

public class ReverseWordsClass
{
    public static string ReverseWords(string str) =>
        string.Join(" ",
            str
            .Split(" ")
            .Select(x => new string([.. x.Reverse()]))
        );
}
