namespace CodeWars.Resolutions;

public class Counter
{
    private int _value = 0;

    public int Value
    {
        get { return _value; }
    }

    public void Increase()
    {
        _value++;
    }

    public void Reset()
    {
        _value = 0;
    }
}
