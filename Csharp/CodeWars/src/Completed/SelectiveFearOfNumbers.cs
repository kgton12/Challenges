namespace CodeWars.Completed;

public class SelectiveFearOfNumbers
{
    public enum DaysWeek
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }
    public static bool AmIAfraid(string day, int num)
    {
        if (day == DaysWeek.Monday.ToString() && num == 12)
            return true;
        else if (day == DaysWeek.Tuesday.ToString() && num > 95)
            return true;
        else if (day == DaysWeek.Wednesday.ToString() && num == 34)
            return true;
        else if (day == DaysWeek.Thursday.ToString() && num == 0)
            return true;
        else if (day == DaysWeek.Friday.ToString() && num % 2 == 0)
            return true;
        else if (day == DaysWeek.Saturday.ToString() && num == 56)
            return true;
        else if (day == DaysWeek.Sunday.ToString() && (num == 666 || num == -666))
            return true;
        else
            return false;
    }
}
