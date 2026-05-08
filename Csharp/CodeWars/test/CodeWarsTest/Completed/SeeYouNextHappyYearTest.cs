using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class SeeYouNextHappyYearTest
{
    [Test, Order(1)]
    public void BasicValues()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(SeeYouNextHappyYear.NextHappyYear(1001), Is.EqualTo(1023));
            Assert.That(SeeYouNextHappyYear.NextHappyYear(1123), Is.EqualTo(1203));
            Assert.That(SeeYouNextHappyYear.NextHappyYear(2001), Is.EqualTo(2013));
            Assert.That(SeeYouNextHappyYear.NextHappyYear(2334), Is.EqualTo(2340));
            Assert.That(SeeYouNextHappyYear.NextHappyYear(3331), Is.EqualTo(3401));
            Assert.That(SeeYouNextHappyYear.NextHappyYear(2342), Is.EqualTo(2345));
            Assert.That(SeeYouNextHappyYear.NextHappyYear(1987), Is.EqualTo(2013));
            Assert.That(SeeYouNextHappyYear.NextHappyYear(2013), Is.EqualTo(2014));
            Assert.That(SeeYouNextHappyYear.NextHappyYear(3000), Is.EqualTo(3012));
        }
    }

    [Test, Order(2)]
    public void LargeValues()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(SeeYouNextHappyYear.NextHappyYear(5555), Is.EqualTo(5601));
            Assert.That(SeeYouNextHappyYear.NextHappyYear(7712), Is.EqualTo(7801));
            Assert.That(SeeYouNextHappyYear.NextHappyYear(8088), Is.EqualTo(8091));
            Assert.That(SeeYouNextHappyYear.NextHappyYear(8800), Is.EqualTo(8901));
            Assert.That(SeeYouNextHappyYear.NextHappyYear(8989), Is.EqualTo(9012));
            Assert.That(SeeYouNextHappyYear.NextHappyYear(8977), Is.EqualTo(9012));
            Assert.That(SeeYouNextHappyYear.NextHappyYear(6869), Is.EqualTo(6870));
            Assert.That(SeeYouNextHappyYear.NextHappyYear(8999), Is.EqualTo(9012));
        }
    }
}
