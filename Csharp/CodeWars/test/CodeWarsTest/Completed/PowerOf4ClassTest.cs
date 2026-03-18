using CodeWars.Resolutions;

namespace CodeWarsTest.Completed;

public class PowerOf4ClassTest
{
    [Test]
    public void BasicTests()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(PowerOf4Class.PowerOf4(0), Is.False);
            Assert.That(PowerOf4Class.PowerOf4(4), Is.True);
            Assert.That(PowerOf4Class.PowerOf4(72), Is.False);
            Assert.That(PowerOf4Class.PowerOf4(20), Is.False);
            Assert.That(PowerOf4Class.PowerOf4(12), Is.False);
            Assert.That(PowerOf4Class.PowerOf4(16), Is.True);
            Assert.That(PowerOf4Class.PowerOf4(1), Is.True);
            Assert.That(PowerOf4Class.PowerOf4(3.1415), Is.False);
            Assert.That(PowerOf4Class.PowerOf4("4"), Is.False);
            Assert.That(PowerOf4Class.PowerOf4(null), Is.False);
        }
    }
}
