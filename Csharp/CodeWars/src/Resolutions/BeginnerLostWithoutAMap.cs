namespace CodeWars.Resolutions;

public class BeginnerLostWithoutAMap
{
    public static int[] Maps(int[] x) =>
        [.. x.Select(x => x * 2)];
}
