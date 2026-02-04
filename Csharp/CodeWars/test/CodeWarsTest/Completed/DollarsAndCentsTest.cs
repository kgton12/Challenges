using CodeWars.Resolutions;

namespace CodeWarsTest.Completed;

public class DollarsAndCentsTest
{
    [Test]
    public void SampleTest()
    {
        Assert.That(DollarsAndCents.FormatMoney(39.99), Is.EqualTo("$39.99"), "That's not formatted the way we expected.");
    }
}
