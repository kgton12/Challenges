namespace CodeWars.Completed;

public class BrokenCounter
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
