namespace CodeWars.Completed;

public class OperationsWithSets
{
    public static int[] Process2Arrays(int[] arr1, int[] arr2)
    {
        int common = arr1.Intersect(arr2).Count();
        int onlyInFirst = arr1.Except(arr2).Count();
        int onlyInSecond = arr2.Except(arr1).Count();

        return [common, onlyInFirst + onlyInSecond, onlyInFirst, onlyInSecond];
    }
}