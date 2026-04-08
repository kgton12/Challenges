namespace CodeWars.Completed;

public class FindCountOfMostFrequentItemInAnArray
{
    public static int MostFrequentItemCount(int[] collection) =>
        collection.GroupBy(g => g).Select(s => s.Count()).DefaultIfEmpty(0).Max();
}
