namespace CodeWars.Completed;

public class PairOfGloves
{
    public static int NumberOfPairs(string[] gloves) =>
        gloves.GroupBy(x => x)
              .Sum(x => x.Count() / 2);
}