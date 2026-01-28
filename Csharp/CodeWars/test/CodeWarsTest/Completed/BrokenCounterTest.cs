using CodeWars.Resolutions;

namespace CodeWarsTest.Completed;

public class BrokenCounterTest
{
    [Test]
    public void Test()
    {
        BrokenCounter counter = new();
        Assert.That(counter.Value, Is.EqualTo(0), "Initial counter value must be 0");
        counter.Increase();
        Assert.That(counter.Value, Is.EqualTo(1), "Counter value must be incremented.");
        counter.Reset();
        Assert.That(counter.Value, Is.EqualTo(0), "Counter value must be reset.");
    }
}
