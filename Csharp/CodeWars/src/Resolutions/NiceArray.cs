namespace CodeWars.src.Resolutions;

public static class NiceArray
{
    public static bool IsNice(int[] arr) =>
        arr.Length != 0 && arr.All(x => arr.Contains(x - 1) || arr.Contains(x + 1));
}
