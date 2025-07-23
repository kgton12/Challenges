namespace CodeWars.src.Resolutions;

public class NthSmallestElementArraySeries4
{
    public static int NthSmallest(int[] arr, int pos) =>
        Convert.ToInt32(arr.OrderBy(x => x).ElementAtOrDefault(pos - 1));
}
