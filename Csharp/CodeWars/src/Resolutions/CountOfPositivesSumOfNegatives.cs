namespace CodeWars.Resolutions;

public class CountOfPositivesSumOfNegatives
{
    public static int[] CountPositivesSumNegatives(int[]? input)
    {
        if (input == null || input.Length == 0) return [];

        return [input.Count(x => x > 0),
            input.Where(x => x < 0).Sum()];
    }
}
