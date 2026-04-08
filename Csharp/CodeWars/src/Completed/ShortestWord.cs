namespace CodeWars.Completed;

public class ShortestWord
{
    public static int FindShort(string s) =>
        s.Split(" ").Min(x => x.Length);
}
