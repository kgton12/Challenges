namespace CodeWars.Completed;

public class BeginnerSeries2Clock
{
    public static int Past(int h, int m, int s) =>
       (h * 60 * 60 + m * 60 + s) * 1000;
}
