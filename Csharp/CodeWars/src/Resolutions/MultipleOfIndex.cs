namespace CodeWars.src.Resolutions;

public class MultipleOfIndexClass
{
    public static List<int> MultipleOfIndex(List<int> xs) =>
        [.. xs.Where((x, index) => index == 0 && x == 0 || index != 0 && x % index == 0)];
}
