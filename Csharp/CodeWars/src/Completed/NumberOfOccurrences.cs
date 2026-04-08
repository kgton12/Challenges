namespace CodeWars.Completed;

public class NumberOfOccurrencesClass
{
    public static int NumberOfOccurrences(int x, int[] xs) => xs.Count(v => v == x);
}
