namespace CodeWars.Completed;

public class BoiledEggs
{
    public static int CookingTime(int eggs) =>
        (int)Math.Ceiling(eggs / 8.0) * 5;
}
