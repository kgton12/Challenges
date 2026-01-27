namespace CodeWars.Resolutions;

public class SurfaceAreaAndVolumeOfABox
{
    public static int[] Get_size(int w, int h, int d)
    {
        var surface = (w * h + w * d + h * d) * 2;
        var cubic = w * h * d;

        return [surface, cubic];
    }
}

