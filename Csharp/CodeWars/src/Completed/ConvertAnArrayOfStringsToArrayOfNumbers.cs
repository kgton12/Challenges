using System.Globalization;

namespace CodeWars.Completed;

public class ConvertAnArrayOfStringsToArrayOfNumbers
{
    public static double[] ToDoubleArray(string[] stringArray)
    {
        return [.. stringArray.Select(s => double.Parse(s, CultureInfo.InvariantCulture))];
    }
}
