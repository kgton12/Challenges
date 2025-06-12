namespace CodeWars.src.Resolutions;

public class RowWeightsClass
{
    public static int[] RowWeights(int[] a)
    {
        int teamA = a.Where((_, index) => index % 2 == 0).Sum();
        int teamB = a.Where((_, index) => index % 2 == 1).Sum();

        return [teamA, teamB];
    }
}