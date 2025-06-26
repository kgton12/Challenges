namespace CodeWars.src.Resolutions;

public class NumberOfOccurrencesClass
{
    public static int NumberOfOccurrences(int x, int[] xs) => xs.Count(v => v == x);
}
