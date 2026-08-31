using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class LogWithoutDatesTest
{
    [Test, Order(1)]
    public void SampleTest()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(LogWithoutDates.CheckLogs(["12:12:12"]), Is.EqualTo(1));
            Assert.That(LogWithoutDates.CheckLogs(["00:00:00", "00:01:11", "02:15:59", "23:59:58", "23:59:59"]), Is.EqualTo(1));
            Assert.That(LogWithoutDates.CheckLogs(["12:00:00", "23:59:59", "00:00:00"]), Is.EqualTo(2));
            Assert.That(LogWithoutDates.CheckLogs(["12:00:00", "12:00:00", "00:00:00"]), Is.EqualTo(3));
            Assert.That(LogWithoutDates.CheckLogs(["00:00:00", "00:00:00", "00:00:00", "00:00:00", "00:00:00"]), Is.EqualTo(5));
            Assert.That(LogWithoutDates.CheckLogs(["10:10:10", "11:11:11", "12:12:12", "13:13:13", "14:14:14", "15:15:15", "16:16:16"]), Is.EqualTo(1));
            Assert.That(LogWithoutDates.CheckLogs(["23:59:59", "00:00:00"]), Is.EqualTo(2));
            Assert.That(LogWithoutDates.CheckLogs(["00:00:00", "00:00:01", "00:00:01"]), Is.EqualTo(2));
            Assert.That(LogWithoutDates.CheckLogs([]), Is.Zero);
            Assert.That(LogWithoutDates.CheckLogs([.. Enumerable.Repeat("00:00:00", 30)]), Is.EqualTo(30));
        }
    }

    private static readonly Random Rand = new();

    [Test, Order(2)]
    public void RandomTest()
    {
        for (var i = 0; i < 100; i++)
        {
            var log = GenerateArrayTime();
            var expected = Solution(log);
            var message = FailureMessage(log, expected);
            var actual = LogWithoutDates.CheckLogs(log);
            Assert.That(actual, Is.EqualTo(expected), message);
        }
    }

    private static int Solution(string[] log)
    {
        var timeLog = log.Select(TimeOnly.Parse).ToArray();
        var days = 0;

        for (var i = 0; i < timeLog.Length; i++)
        {
            if (i == 0 || timeLog[i] <= timeLog[i - 1])
                days++;
        }

        return days;
    }

    private static string[] GenerateArrayTime()
    {
        var num = Rand.Next(2, 100);
        var result = new List<string>();
        for (var i = 0; i < num; i++)
        {
            var hh = Rand.Next(0, 24).ToString("00");
            var mm = Rand.Next(0, 60).ToString("00");
            var ss = Rand.Next(0, 60).ToString("00");

            var time = string.Join(":", hh, mm, ss);
            result.Add(time);

            // randomly duplicate some elements (otherwise they very rarery occur)
            if (num < 80 && result.Count < 80 && Rand.Next(0, 6) == 0) result.Add(time);
        }

        return [.. result];
    }

    private static string FailureMessage(string[] actual, int expected)
    {
        return $"Should return {expected} with log=[{string.Join(", ", actual.Select(x => $"\"{x}\""))}]";
    }
}