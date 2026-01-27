namespace CodeWars.Resolutions;

public class DontGiveMeFiveClass
{
    public static int DontGiveMeFive(int start, int end) =>
        Enumerable.Range(start, end - start + 1).Count(x => !x.ToString().Contains('5'));
}
