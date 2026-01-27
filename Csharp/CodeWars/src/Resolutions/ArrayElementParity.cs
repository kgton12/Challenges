namespace CodeWars.Resolutions;

public class ArrayElementParity
{
    public static int Solve(List<int> arr) =>
        arr
        .Where(x => x > 0
            ? !arr.Contains(x - x * 2)
            : !arr.Contains(x + Math.Abs(x * 2))
        )
        .First();
}
