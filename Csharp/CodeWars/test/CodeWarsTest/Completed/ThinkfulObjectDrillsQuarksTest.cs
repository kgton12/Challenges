using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class ThinkfulObjectDrillsQuarksTest
{
    [Test]
    public void SampleTest()
    {
        Quark q1 = new Quark("red", "up");
        Quark q2 = new Quark("blue", "strange");
        using (Assert.EnterMultipleScope())
        {
            Assert.That(q1.Color, Is.EqualTo("red"));
            Assert.That(q2.Flavor, Is.EqualTo("strange"));
        }
        double expectedBaryonNumber = 1 / 3d;
        Assert.That(q2.BaryonNumber, Is.EqualTo(expectedBaryonNumber));

        q1.Interact(q2);
        Assert.That(q1.Color, Is.EqualTo("blue"));
    }
}
