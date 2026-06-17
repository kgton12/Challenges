using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class Converting12HourTimeTo24HourTimeTest
{
    [TestCase(1, 0, ExpectedResult = "0100", Description = "Should return \"0100\" for hour=1, minutes=0, period=\"am\"")]
    [TestCase(2, 15, ExpectedResult = "0215", Description = "Should return \"0215\" for hour=2, minutes=15, period=\"am\"")]
    public string TestPeriodAm(int hour, int minutes) =>
          Converting12HourTimeTo24HourTime.Convert12hTo24h(hour, minutes, "am");

    [TestCase(1, 0, ExpectedResult = "1300", Description = "Should return \"1300\" for hour=1, minutes=0, period=\"pm\"")]
    [TestCase(2, 15, ExpectedResult = "1415", Description = "Should return \"1415\" for hour=2, minutes=15, period=\"pm\"")]
    public string TestPeriodPm(int hour, int minutes) =>
      Converting12HourTimeTo24HourTime.Convert12hTo24h(hour, minutes, "pm");

    [TestCase("am", ExpectedResult = "0000", Description = "Midnight: should return \"0000\" for hour=12, minutes=0, period=\"am\"")]
    [TestCase("pm", ExpectedResult = "1200", Description = "Noon: should return \"1200\" for hour=12, minutes=0, period=\"pm\"")]
    public string TestEdgeCases(string period) =>
      Converting12HourTimeTo24HourTime.Convert12hTo24h(12, 0, period);
}
