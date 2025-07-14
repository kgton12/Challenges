namespace CodeWars.src.Resolutions;

public class FindMultiplesOfANumber
{
    public static List<int> FindMultiples(int n, int limit) =>
        [.. Enumerable.Range(n, limit - n + 1).Where(x => x % n == 0)];
}
