namespace CodeWars.src.Resolutions;

public class StopGninnipSMySdroW
{
    public static string SpinWords(string sentence) =>
        string.Join(" ", sentence.Split(' ').Select(ReverseWord));

    private static string ReverseWord(string word) =>
        word.Length >= 5 ? string.Concat(word.Reverse()) : word;
}
