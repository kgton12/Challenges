namespace CodeWars.Completed;

public class DifferenceOfVolumesOfCuboids
{
    public static int FindDifference(int[] a, int[] b) =>
        Math.Abs(
            a.Aggregate(1, (acc, val) => acc * val) - b.Aggregate(1, (acc, val) => acc * val)
        );
}
