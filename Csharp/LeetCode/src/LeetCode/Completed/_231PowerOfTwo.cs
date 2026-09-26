namespace LeetCode.Completed;

public class _231PowerOfTwo
{
    public static bool IsPowerOfTwo(int n) =>
        n > 0 && (n & (n - 1)) == 0;
}