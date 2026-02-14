namespace CodeWars.Resolutions;

public class WhatsMyGolfScore
{
    public static int GolfScoreCalculator(string par, string score) =>
        par.Zip(score, (p, s) => s - p).Sum();
}