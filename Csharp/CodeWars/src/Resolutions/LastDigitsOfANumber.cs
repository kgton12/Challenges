namespace CodeWars.src.Resolutions;

public class LastDigitsOfANumber
{
    public static int[] LastDigit(long n, int d) =>
        d <= 0
            ? []
            : [..
                n
                .ToString()
                .TakeLast(d)
                .Select(x => x - 'a')
            ];
}
