namespace CodeWars.Completed;

public class ClosestToZero
{
    public static int? Closest(int[] arr)
    {
        var arrClean = arr.Distinct().ToArray();
        var closest = arrClean.OrderBy(Math.Abs).FirstOrDefault();

        return arrClean.Any(x => closest == -x && x != 0)
            ? null
            : closest;
    }
}