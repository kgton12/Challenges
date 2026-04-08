namespace CodeWars.Completed;

public class SortTheOdd
{
    public static int[] SortArray(int[] array)
    {
        List<int> orderedValues = [];
        Queue<int> orderedOdd = new(array.Where(x => x % 2 != 0).OrderBy(x => x));

        return [.. array.Select(x =>
        {
            if (x % 2 == 0) return x;
            return orderedOdd.Dequeue();
        })];
    }
}
