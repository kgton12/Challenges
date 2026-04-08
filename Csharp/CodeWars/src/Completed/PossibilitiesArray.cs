namespace CodeWars.Completed;

public class PossibilitiesArray
{
    public static bool IsAllPossibilities(int[] arr) =>
        arr.Length != 0 &&
        Enumerable.Range(0, arr.Length).All(arr.Contains);
}
