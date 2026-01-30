using CodeWars.Resolutions;

namespace CodeWarsTest.Completed;

public class BeginnerSeries4CockroachTest
{
    [Test]
    public void Test1()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(BeginnerSeries4Cockroach.CockroachSpeed(1.08), Is.EqualTo(30));
            Assert.That(BeginnerSeries4Cockroach.CockroachSpeed(1.09), Is.EqualTo(30));
            Assert.That(BeginnerSeries4Cockroach.CockroachSpeed(0), Is.Zero);
        }
    }
}
