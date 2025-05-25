using System.Globalization;

namespace BeeCrowd.src.Resolutions.Beginner;

public class Beecrowd1052
{
    public static void Month()
    {
        int monthNumber = Convert.ToInt32(Console.ReadLine() ?? string.Empty);

        DateTimeFormatInfo formatInfo = DateTimeFormatInfo.CurrentInfo;
        string monthName = formatInfo.GetMonthName(monthNumber);

        monthName = string.Concat(monthName[0].ToString().ToUpper(), monthName.AsSpan(1));

        Console.WriteLine(monthName);
    }
}
