namespace CodeWars.src.Resolutions;

public class RockPaperScissors
{
    private static readonly Dictionary<string, (string win, string lose)> GAME = new()
    {
        { "rock", ("scissors", "paper") },
        { "paper", ("rock", "scissors") },
        { "scissors", ("paper", "rock") }
    };
    public static string Rps(string p1, string p2)
    {
        if (p1 == p2)
            return "Draw!";

        return p2 == GAME[p1].win ? "Player 1 won!" : "Player 2 won!";
    }
}
