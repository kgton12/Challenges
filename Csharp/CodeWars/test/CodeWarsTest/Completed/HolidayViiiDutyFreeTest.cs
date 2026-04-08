using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class HolidayViiiDutyFreeTest
{
    [Test]
    public void SampleTest()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(HolidayViiiDutyFree.DutyFree(12, 50, 1000), Is.EqualTo(166));
            Assert.That(HolidayViiiDutyFree.DutyFree(17, 10, 500), Is.EqualTo(294));
            Assert.That(HolidayViiiDutyFree.DutyFree(24, 35, 3000), Is.EqualTo(357));
        }
    }
}
