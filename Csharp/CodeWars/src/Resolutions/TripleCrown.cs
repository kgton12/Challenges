namespace CodeWars.src.Resolutions;

public class TripleCrownClass
{
    public static string TripleCrown(Dictionary<string, Dictionary<string, int>> receivers)
    {
        var categories = new List<string> { "Receiving yards", "Receiving touchdowns", "Receptions" };

        var leaders = new Dictionary<string, string>();

        foreach (var category in categories)
        {
            int maxValue = receivers.Max(player => player.Value[category]);

            var topPlayers = receivers
                .Where(player => player.Value[category] == maxValue)
                .Select(player => player.Key)
                .ToList();

            if (topPlayers.Count != 1)
                return "None of them";

            leaders[category] = topPlayers[0];
        }

        if (leaders.Values.Distinct().Count() == 1)
            return leaders.Values.First();

        return "None of them";
    }
}
