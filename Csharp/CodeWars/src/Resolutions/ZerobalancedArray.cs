namespace CodeWars.src.Resolutions;

public class ZerobalancedArray
{
    public static bool IsZeroBalanced(List<int> xs) =>
        xs.All(x => xs.Contains(-x))
           && xs.Sum() == 0
           && xs.Count != 0;
}