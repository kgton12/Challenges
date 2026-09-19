namespace CodeWars.Completed;

public class SimpleFun3LateRide
{
    public static int LateRide(int n)
    {
        TimeOnly time = new TimeOnly().AddMinutes(n);
        return (int)$"{time.Hour}{time.Minute}".Sum(char.GetNumericValue);
    }
}