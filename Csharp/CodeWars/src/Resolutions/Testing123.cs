namespace CodeWars.Resolutions;

public class Testing123
{
    public static List<string> Number(List<string> lines) =>
        [.. lines.Select((value, index) => $"{index + 1}: {value}")];
}
