namespace CodeWars.Completed;

public class GhostbustersWhitespaceRemoval
{
    public static string GhostBusters(string building) =>
        building.Contains(' ')
            ? building.Replace(" ", string.Empty)
            : "You just wanted my autograph didn't you?";
}
