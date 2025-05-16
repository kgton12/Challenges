namespace CodeWars.src.Resolutions;

public class CSVRepresentationOfArray
{
    public static string ToCsvText(int[][] array)
    {
        return string.Join('\n', array.Select(row => string.Join(',', row)));
    }
}

