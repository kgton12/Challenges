namespace CodeWars.src.Resolutions;

internal class BoiledEggs
{
    public static int CookingTime(int eggs) =>
        (int)Math.Ceiling(eggs / 8.0) * 5;
}
