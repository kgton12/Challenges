namespace CodeWars.Resolutions;

public class IncrementerClass
{
    public static int[] Incrementer(int[] numbers) => [.. numbers.Select((digit, index) => (digit + index + 1) % 10)];
}
