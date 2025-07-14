namespace CodeWars.src.Resolutions;

public class ReverseListOrder
{
    public static List<int> ReverseList(List<int> list) =>
        [.. Enumerable.Reverse(list)];
}
