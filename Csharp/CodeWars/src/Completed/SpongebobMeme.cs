namespace CodeWars.Completed;

public class SpongebobMemeClass
{
    public static string SpongeMeme(string sentence) =>
        string.Concat(sentence.Select((x, i) => i % 2 == 0 ? char.ToUpper(x) : char.ToLower(x)));
}
