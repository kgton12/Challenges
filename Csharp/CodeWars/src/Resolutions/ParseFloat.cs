namespace CodeWars.src.Resolutions;

public class ParseFloat
{
    public static double? ParseF(object? s = null) =>
        s is null || !double.TryParse(s.ToString(), out double value) ? null : value;
}
