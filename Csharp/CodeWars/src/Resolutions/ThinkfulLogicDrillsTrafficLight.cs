namespace CodeWars.src.Resolutions;

public class ThinkfulLogicDrillsTrafficLight
{
    public static string UpdateLight(string current)
    {
        Dictionary<string, string> lightsSequence = new()
        {
            {"green", "yellow"},
            {"yellow", "red" },
            {"red", "green" },
        };
        return lightsSequence[current];
    }
}