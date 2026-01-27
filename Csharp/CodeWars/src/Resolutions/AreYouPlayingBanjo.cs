namespace CodeWars.Resolutions;

public class AreYouPlayingBanjoClass
{
    public static string AreYouPlayingBanjo(string name) =>
        name.StartsWith("r", StringComparison.OrdinalIgnoreCase)
        ? $"{name} plays banjo"
        : $"{name} does not play banjo";
}
