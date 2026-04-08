namespace CodeWars.Completed;

public class StringRepeat
{
    public static string RepeatStr(int n, string s) =>
        string.Concat(Enumerable.Repeat(s, n));
}
