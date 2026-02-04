namespace CodeWars.Resolutions;

public class LastDigitsOfANumber
{
    public static int[] LastDigit(long n, int d) =>
        d <= 0
            ? []
            : [..
                n
                .ToString()
                .TakeLast(d)
                .Select(x => (int)char.GetNumericValue(x))
            ];
}
