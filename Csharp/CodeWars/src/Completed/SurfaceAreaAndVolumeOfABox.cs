namespace CodeWars.Completed;

public class SurfaceAreaAndVolumeOfABox
{
    public static int[] GetSize(int w, int h, int d)
    {
        var surface = (w * h + w * d + h * d) * 2;
        var cubic = w * h * d;

        return [surface, cubic];
    }
}

