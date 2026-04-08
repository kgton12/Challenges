namespace CodeWars.Completed;

public class InspiringStrings
{
    public static string LongestWord(string stringOfWords) =>
        stringOfWords.Split().OrderBy(w => w.Length).Last();
}
