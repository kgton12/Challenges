namespace LeetCode.Completed;

public class RemoveDuplicatesFromSortedArray
{
    public static int RemoveDuplicates(int[] nums) =>
        nums.Distinct().Count();
}