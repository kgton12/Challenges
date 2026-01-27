namespace CodeWars.Resolutions;

public class SimpleRemoveDuplicates
{
    public static int[] Solve(int[] arr) =>
        [.. arr.Reverse().Distinct().Reverse()];
}
