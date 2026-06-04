namespace LeetCode;

public class MergeSortedArray
{
    public static void Merge(int[] nums1, int m, int[] nums2, int n)
    {
        var arrayMerged = nums1.Take(m).Concat(nums2.Take(n)).OrderBy(x => x).ToArray();

        for (int i = 0; i < arrayMerged.Length; i++)
            nums1[i] = arrayMerged[i];
    }
}