namespace LeetCode.Completed;

public class SearchInsertPosition
{
    public static int SearchInsert(int[] nums, int target)
    {
        if (nums.Any(x => x.Equals(target)))
            return nums.IndexOf(target);
        else
            return nums
                     .Append(target)
                     .OrderBy(x => x)
                     .ToArray()
                     .IndexOf(target);
    }
}