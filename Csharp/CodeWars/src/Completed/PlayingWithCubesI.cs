namespace CodeWars.Completed;

public class Cube(int c = 0)
{
    private int Side = c;

    public int GetSide()
    {
        return Math.Abs(this.Side);
    }

    public void SetSide(int s)
    {
        this.Side = s;
    }
}
