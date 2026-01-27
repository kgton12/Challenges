namespace CodeWars.Resolutions;

public class Quadrants
{
    public static int Quadrant(int x, int y)
    {
        return (x, y) switch
        {
            ( > 0, > 0) => 1,
            ( < 0, > 0) => 2,
            ( < 0, < 0) => 3,
            ( > 0, < 0) => 4,
            _ => 0
        };
    }
}