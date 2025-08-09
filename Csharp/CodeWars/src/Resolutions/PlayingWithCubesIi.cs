namespace CodeWars.src.Resolutions;

public class Cube1(int c = 0)
{
    private int Side = c;

    public int GetSide()
    {
        return Math.Abs(Side);
    }

    public void SetSide(int s)
    {
        Side = s;
    }
}
