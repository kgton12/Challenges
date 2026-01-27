namespace CodeWars.Resolutions;

public class RemoveDuplicatesFromList
{
    public static int[] distinct(int[] a) =>
        [.. a.Distinct()];
}
