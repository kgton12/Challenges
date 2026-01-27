namespace CodeWars.Resolutions;

public class TheFallingSpeedOfPetals
{
    public static double SakuraFall(double v) =>
        v < 0 ? 0 : 400.0 / v;
}
