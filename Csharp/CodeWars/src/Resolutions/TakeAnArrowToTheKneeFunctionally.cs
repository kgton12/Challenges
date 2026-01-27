namespace CodeWars.Resolutions;

public class TakeAnArrowToTheKneeFunctionally
{
    public static string ArrowFunc(int[] arr) => string.Join("", arr.Select(x => (char)x).ToArray());
}
