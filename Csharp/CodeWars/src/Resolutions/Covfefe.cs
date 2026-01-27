namespace CodeWars.Resolutions;

public class CovfefeClass
{
    public static string Covfefe(string tweet) =>
        tweet.Contains("coverage")
            ? tweet.Replace("coverage", "covfefe")
            : $"{tweet} covfefe";
}
