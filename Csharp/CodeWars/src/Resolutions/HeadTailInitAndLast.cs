namespace CodeWars.src.Resolutions;

public static class HeadTailInitAndLast
{
    public static TSource Head<TSource>(this List<TSource> list) => list[0];

    public static List<TSource> Tail<TSource>(this List<TSource> list) => [.. list.Skip(1)];

    public static List<TSource> Init<TSource>(this List<TSource> list) => [.. list.Take(list.Count - 1)];

    public static TSource Last_<TSource>(this List<TSource> list) => list.Last();
}
