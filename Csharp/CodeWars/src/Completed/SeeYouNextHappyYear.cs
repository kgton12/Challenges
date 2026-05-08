namespace CodeWars.Completed;

public class SeeYouNextHappyYear
{
    public static short NextHappyYear(short year)
    {
        while (true)
        {
            if ((++year).ToString().Distinct().Count() == 4)
                return year;
        }
    }
}
