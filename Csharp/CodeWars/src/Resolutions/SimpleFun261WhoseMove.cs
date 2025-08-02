namespace CodeWars.src.Resolutions;

public class SimpleFun261WhoseMove
{
    public static string WhoseMove(string lastPlayer, bool win) =>
        win ? lastPlayer : lastPlayer == "white" ? "black" : "white";
}
