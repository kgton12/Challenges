namespace CodeWars.src.Resolutions;

public class ArrayOfTwins
{
    public static bool Twins(int[] arr) =>
        arr.GroupBy(x => x)
           .All(x => x.Count() == 2);
}
