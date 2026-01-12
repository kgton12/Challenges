namespace CodeWars.src.Resolutions;

public class MultiplyTheStringsInTheArray
{
    public static string ArrMultiply(string[] arr) =>
        (Convert.ToInt32(arr[0]) * Convert.ToInt32(arr[1])).ToString();
}
