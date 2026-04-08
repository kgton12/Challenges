using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class BeginnerSeries2ClockTest
{
    [Test]
    public void Test()
    {
        Assert.That(BeginnerSeries2Clock.Past(0, 1, 1), Is.EqualTo(61000));
    }
}
