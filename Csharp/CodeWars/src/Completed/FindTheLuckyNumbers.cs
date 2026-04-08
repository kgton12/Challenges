namespace CodeWars.Completed;

public static class FindTheLuckyNumbers
{
    public static int[] FilterLucky(int[] x) => [.. x.Where(x => x.ToString().Contains('7'))];
}
