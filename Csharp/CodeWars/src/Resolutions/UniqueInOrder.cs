namespace CodeWars.Resolutions;

public class UniqueInOrderClass
{
    public static IEnumerable<T> UniqueInOrder<T>(IEnumerable<T> iterable) =>
        iterable.Where((x, i) => i == 0 || x != null && !x.Equals(iterable.ElementAt(i - 1)));
}
