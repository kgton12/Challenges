namespace LeetCode.Completed;

public class LengthOfLastWordClass
{
    public static int LengthOfLastWord(string s)
    {
        return s.Split(' ', StringSplitOptions.RemoveEmptyEntries).Last().Length;
    }
}