namespace CodeWars.Completed;

public class PickASetOfFirstElements
{
    public static object[] TakeFirstElements(object[] array, int n = 1) => [.. array.Take(n)];
}
