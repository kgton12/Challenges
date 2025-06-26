namespace CodeWars.src.Resolutions;

public class SumAListButIgnoreAnyDuplicates
{
    public static int SumNoDuplicates(int[] arr) =>
        arr.Where(x => arr.Count(c => c == x) == 1).Sum();
}
