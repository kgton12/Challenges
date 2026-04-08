namespace CodeWars.Completed;

public class CurryingFunctionsMultiplyAllElementsInAnArray
{
    public static Func<int, int[]> MultiplyAll(int[] a) => i => [.. a.Select(x => x * i)];
}