namespace CodeWars.Resolutions;

public class PrintingArrayElementsWithCommaDelimiters
{
    public static string PrintArray(object[] array) =>
        string.Join(",", array.Select(x =>
            x is Array arr ? PrintArray([.. arr.Cast<object>()]) : Convert.ToString(x)
        ));
}
