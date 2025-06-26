namespace CodeWars.src.Resolutions;

public static class FindAllOccurrencesOfAnElementInAnArray
{
    public static int[] FindAll(int[] array, int n) =>
        [.. Enumerable.Range(0, array.Length).Where(i => array[i] == n)];
}
