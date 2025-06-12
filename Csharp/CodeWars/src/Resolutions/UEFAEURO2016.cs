namespace CodeWars.src.Resolutions;

public class UEFAEURO2016
{
    public static string UefaEuro2016(string[] teams, int[] scores)
    {
        return (scores[0], scores[1]) switch
        {
            var (a, b) when a > b => $"At match {teams[0]} - {teams[1]}, {teams[0]} won!",
            var (a, b) when a < b => $"At match {teams[0]} - {teams[1]}, {teams[1]} won!",
            _ => $"At match {teams[0]} - {teams[1]}, teams played draw."
        };
    }
}
