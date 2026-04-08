using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class CenturyFromYearTest
{
    [Test]
    public void SampleTest()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(CenturyFromYear.СenturyFromYear(1705), Is.EqualTo(18));
            Assert.That(CenturyFromYear.СenturyFromYear(1900), Is.EqualTo(19));
            Assert.That(CenturyFromYear.СenturyFromYear(1601), Is.EqualTo(17));
            Assert.That(CenturyFromYear.СenturyFromYear(2000), Is.EqualTo(20));
        }
    }
}
