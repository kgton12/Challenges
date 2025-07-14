namespace CodeWars.src.Resolutions;

public class BeginnerReduceButGrow
{
    public static int Grow(int[] x) =>
        x.Aggregate(1, (accumulator, item) => accumulator * item);
}
