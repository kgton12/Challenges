namespace CodeWars.Resolutions;

public class PullYourWordsTogetherMan
{
    public static string Sentencify(string[] words) =>
        string.Concat(
            string
            .Join(" ", words)
            .Select((x, i) => i == 0 ? char.ToUpper(x) : x)
        ) + ".";
}
