namespace CodeWars.Resolutions;

public class ReverseListClass
{
    public static int[] ReverseList(int[] list) =>
        list.Length > 0 ? [.. list.Reverse()] : [];
}
