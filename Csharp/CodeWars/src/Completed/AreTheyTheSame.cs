namespace CodeWars.Completed;

public class AreTheyTheSame
{
    public static bool Comp(int[] a, int[] b)
    {
        if (a is null || b is null) return false;
        if (a.Length != b.Length) return false;

        int[] aSquared = [.. a.Select(num => num * num).OrderBy(num => num)];
        int[] bSorted = [.. b.OrderBy(num => num)];

        return !aSquared.Where((val, index) => val != bSorted[index]).Any();
    }
}
