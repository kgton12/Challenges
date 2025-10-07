namespace CodeWars.src.Resolutions;

public class FindArrayClass
{
    public static object[] FindArray(object[] arr1, int[] arr2) =>
         [.. arr2.Where(x => x < arr1.Length).Select(x => arr1[x])];
}
