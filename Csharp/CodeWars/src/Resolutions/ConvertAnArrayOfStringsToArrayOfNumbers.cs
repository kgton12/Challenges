using System.Globalization;

namespace CodeWars.Resolutions;

public class ConvertAnArrayOfStringsToArrayOfNumbers
{
    public static double[] ToDoubleArray(string[] stringArray)
    {
        return [.. stringArray.Select(s => double.Parse(s, CultureInfo.InvariantCulture))];
    }
}
