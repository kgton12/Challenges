namespace CodeWars.src.Resolutions;

public class WhichAreIn
{
    public static string[] InArray(string[] array1, string[] array2) =>
        [.. array1.Where(x => array2.Any(z => z.Contains(x))).OrderBy(x => x)];
}
