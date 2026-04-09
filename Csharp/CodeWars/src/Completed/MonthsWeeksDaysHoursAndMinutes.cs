using System.Text;

namespace CodeWars.Completed;

public class MonthsWeeksDaysHoursAndMinutes
{
    public static string DisplayValue(int value)
    {
        StringBuilder result = new();
        string s = string.Empty;

        Dictionary<string, int> calendar =
        new()
        {
            { "month", 40320 },
            { "week", 10080 },
            { "day", 1440 },
            { "hour", 60 },
            { "minute", 1 },
        };

        foreach (var c in calendar)
        {
            if (value >= c.Value)
            {
                int number = value / c.Value;
                value -= (number * c.Value);
                if (number > 1)
                    s = "s";

                result.Append($"{number} {c.Key}{s} ");
                s = string.Empty;
            }
        }

        return result.ToString().Trim();
    }
}