namespace CodeWars.src.Resolutions;

public class InvertValuesClass
{
    public static int[] InvertValues(int[] input) =>
        [.. input.Select(x => x * -1)];
}
