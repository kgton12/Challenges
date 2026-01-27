namespace CodeWars.Resolutions;

public class AlanPartridgeIiAppleTurnover
{
    public static string Apple(object n) =>
        Convert.ToInt32(n) <= 31
        ? "Help yourself to a honeycomb Yorkie for the glovebox."
        : "It's hotter than the sun!!";
}
