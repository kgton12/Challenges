namespace CodeWars.Completed;

public class RemovingElements
{
    public static object[] RemoveEveryOther(object[] arr)
    {
        return [.. arr.Where((value, index) => index % 2 == 0)];
    }
}
