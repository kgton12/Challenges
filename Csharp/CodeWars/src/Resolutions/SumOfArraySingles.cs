namespace CodeWars.src.Resolutions;

public class SumOfArraySingles
{
    public static int Repeats(List<int> source) =>
        source.GroupBy(x => x).Where(x => x.Count() == 1).Sum(x => x.Key);
}
