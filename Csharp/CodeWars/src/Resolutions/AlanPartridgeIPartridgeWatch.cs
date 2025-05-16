namespace CodeWars.src.Resolutions;

public class AlanPartridgeIPartridgeWatch
{
    public static string Part(string[] x)
    {
        HashSet<string> terms =
        [
            "Partridge", "PearTree", "Chat", "Dan",
            "Toblerone", "Lynn", "AlphaPapa", "Nomad"
        ];

        int count = x.Count(word => terms.Contains(word));

        return count > 0
            ? $"Mine's a Pint{new string('!', count)}"
            : "Lynn, I've pierced my foot on a spike!!";
    }
}