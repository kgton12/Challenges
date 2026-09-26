namespace LeetCode;

public class _217ContainsDuplicate
{
    public static bool ContainsDuplicate(int[] nums)
    {
        HashSet<int> set = [.. nums];
        return nums.Length != set.Count;
    }
}