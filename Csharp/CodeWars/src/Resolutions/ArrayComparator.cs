namespace CodeWars.src.Resolutions
{
    public class ArrayComparator
    {
        public static int MatchArrays(int[] v, int[] r) =>
            v.Distinct().Count(x => r.Contains(x));
    }
}
