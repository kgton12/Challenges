namespace CodeWars.src.Resolutions;

public class SortNumbersClass
{
    public static int[] SortNumbers(int[] nums) => nums is null ? [] : [.. nums.OrderBy(x => x)];
}
