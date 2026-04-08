namespace CodeWars.Completed;

public class RgbToHexConversion
{
    public static string Rgb(int r, int g, int b)
    {
        List<int> rgb = [r, g, b];
        List<string> output = [];

        foreach (var item in rgb)
            output.Add(ConvertDecInHex(item));

        return string.Concat(output);
    }

    private static string ConvertDecInHex(int r)
    {
        var tempValue = r;

        if (r < 0)
            tempValue = 0;

        if (r > 255)
            tempValue = 255;

        return Convert.ToString(tempValue, 16)
                 .PadLeft(2, '0')
                 .ToUpper();
    }
}