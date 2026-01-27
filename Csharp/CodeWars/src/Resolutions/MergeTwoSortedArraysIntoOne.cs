namespace CodeWars.Resolutions;

public class MergeTwoSortedArraysIntoOne
{
    public static int[] MergeArrays(int[] arr1, int[] arr2)
    {
        HashSet<int> set = [.. arr1.Concat(arr2).OrderBy(x => x)];

        return [.. set];
    }
}