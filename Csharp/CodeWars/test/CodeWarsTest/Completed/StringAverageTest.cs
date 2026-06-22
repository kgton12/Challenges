using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class StringAverageTest
{
    [Test]
    public void SampleTests()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(StringAverage.AverageString("zero nine five two"), Is.EqualTo("four"));
            Assert.That(StringAverage.AverageString("four six two three"), Is.EqualTo("three"));
            Assert.That(StringAverage.AverageString("one two three four five"), Is.EqualTo("three"));
            Assert.That(StringAverage.AverageString("five four"), Is.EqualTo("four"));
            Assert.That(StringAverage.AverageString("zero zero zero zero zero"), Is.EqualTo("zero"));
            Assert.That(StringAverage.AverageString("one one eight one"), Is.EqualTo("two"));
            Assert.That(StringAverage.AverageString(""), Is.EqualTo("n/a"));
            Assert.That(StringAverage.AverageString("nine, wedwmw, three, zero"), Is.EqualTo("n/a"));
        }
    }
}