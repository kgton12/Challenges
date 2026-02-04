using CodeWars.Resolutions;

namespace CodeWarsTest.Completed;

public class IsYourPeriodLateTest
{
    [Test]
    public void SampleTest()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(IsYourPeriodLate.PeriodIsLate(new DateTime(2016, 06, 13), new DateTime(2016, 07, 16), 35), Is.False);
            Assert.That(IsYourPeriodLate.PeriodIsLate(new DateTime(2016, 06, 13), new DateTime(2016, 07, 16), 28), Is.True);
        }

        using (Assert.EnterMultipleScope())
        {
            Assert.That(IsYourPeriodLate.PeriodIsLate(new DateTime(2016, 06, 13), new DateTime(2016, 07, 16), 35), Is.False);
            Assert.That(IsYourPeriodLate.PeriodIsLate(new DateTime(2016, 06, 13), new DateTime(2016, 06, 29), 28), Is.False);
            Assert.That(IsYourPeriodLate.PeriodIsLate(new DateTime(2016, 07, 12), new DateTime(2016, 08, 09), 28), Is.False);
            Assert.That(IsYourPeriodLate.PeriodIsLate(new DateTime(2016, 07, 12), new DateTime(2016, 08, 10), 28), Is.True);
            Assert.That(IsYourPeriodLate.PeriodIsLate(new DateTime(2016, 07, 01), new DateTime(2016, 08, 01), 28), Is.True);
            Assert.That(IsYourPeriodLate.PeriodIsLate(new DateTime(2016, 06, 01), new DateTime(2016, 06, 30), 30), Is.False);
            Assert.That(IsYourPeriodLate.PeriodIsLate(new DateTime(2016, 01, 01), new DateTime(2016, 01, 31), 30), Is.False);
            Assert.That(IsYourPeriodLate.PeriodIsLate(new DateTime(2016, 01, 01), new DateTime(2016, 02, 01), 30), Is.True);
            Assert.That(IsYourPeriodLate.PeriodIsLate(new DateTime(2020, 06, 01), new DateTime(2020, 07, 01), 40), Is.False);
            Assert.That(IsYourPeriodLate.PeriodIsLate(new DateTime(2020, 06, 01), new DateTime(2020, 06, 30), 30), Is.False);
            Assert.That(IsYourPeriodLate.PeriodIsLate(new DateTime(2020, 06, 12), new DateTime(2020, 07, 12), 28), Is.True);
            Assert.That(IsYourPeriodLate.PeriodIsLate(new DateTime(2000, 01, 01), new DateTime(2000, 01, 01), 28), Is.False);
            Assert.That(IsYourPeriodLate.PeriodIsLate(new DateTime(2022, 01, 01), new DateTime(2022, 02, 01), 30), Is.True);
            Assert.That(IsYourPeriodLate.PeriodIsLate(new DateTime(2022, 01, 01), new DateTime(2022, 02, 01), 40), Is.False);
        }
    }
}
