namespace CodeWars.Resolutions;

public class ConvertAnArrayOfStringsToArrayOfNumbers
{
    public static double[] ToDoubleArray(string[] stringArray)
    {
        return [.. stringArray.Select(Convert.ToDouble)];
    }
}
