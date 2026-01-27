namespace CodeWars.Resolutions;

public class FormTheMinimum
{
    public static long MinValue(int[] a) =>
        long.Parse(
            string.Concat(
                a.Distinct()
                .OrderBy(x => x)
            )
        );
}
