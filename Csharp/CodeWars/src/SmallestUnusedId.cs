namespace CodeWars.src;

public class SmallestUnusedId
{
    public static int NextId(int[] ids) =>
        Enumerable.Range(0, ids.Max()).Where(x => !ids.Contains(x)).FirstOrDefault(ids.Max() + 1);
}
