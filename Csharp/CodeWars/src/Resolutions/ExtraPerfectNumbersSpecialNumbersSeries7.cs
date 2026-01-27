namespace CodeWars.Resolutions;

public class ExtraPerfectNumbersSpecialNumbersSeries7
{
    public static int[] ExtraPerfect(int n) =>
        [.. Enumerable.Range(1, n).Where(x => x % 2 != 0)];
}
