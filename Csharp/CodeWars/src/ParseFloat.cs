namespace CodeWars.src;

public class ParseFloat
{
    public static double? ParseF(object s = null)
    {
        return double.TryParse(s, out double value);
    }
}
