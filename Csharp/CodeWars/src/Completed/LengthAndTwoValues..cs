namespace CodeWars.Completed;

public class LengthAndTwoValues
{
    public static object[] Alternate(int n, object firstValue, object secondValue) =>
        [.. Enumerable.Range(0, n).Select((_, index) => index % 2 == 0 ? firstValue : secondValue)];
}
