using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class MonthsWeeksDaysHoursAndMinutesTest
{
    [Test]
    public void Fixed()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(MonthsWeeksDaysHoursAndMinutes.DisplayValue(1), Is.EqualTo("1 minute"));
            Assert.That(MonthsWeeksDaysHoursAndMinutes.DisplayValue(100), Is.EqualTo("1 hour 40 minutes"));
            Assert.That(MonthsWeeksDaysHoursAndMinutes.DisplayValue(40321), Is.EqualTo("1 month 1 minute"));
            Assert.That(MonthsWeeksDaysHoursAndMinutes.DisplayValue(52874), Is.EqualTo("1 month 1 week 1 day 17 hours 14 minutes"));
        }
    }
}
