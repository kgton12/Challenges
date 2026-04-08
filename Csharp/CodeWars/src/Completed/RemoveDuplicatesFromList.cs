namespace CodeWars.Completed;

public class RemoveDuplicatesFromList
{
    public static int[] distinct(int[] a) =>
        [.. a.Distinct()];
}
