namespace CodeWars.src.Resolutions;

public class SimpleRemoveDuplicates
{
    public static int[] solve(int[] arr)
    {
        return arr.Reverse().Distinct().Reverse().ToArray();
    }
}
