namespace CodeWars.Completed;

public class LogWithoutDates
{
    public static int CheckLogs(string[] log)
    {
        var timeLog = log.Select(TimeOnly.Parse).ToArray();
        return timeLog.Where((x, i) => i == 0 || x <= timeLog[i - 1]).Count();
    }
}