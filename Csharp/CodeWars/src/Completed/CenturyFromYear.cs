namespace CodeWars.Completed;

public class CenturyFromYear
{
    public static int СenturyFromYear(int year)
    {
        int oneCentury = 100;
        return (int)Math.Ceiling((double)year / oneCentury);
    }
}
