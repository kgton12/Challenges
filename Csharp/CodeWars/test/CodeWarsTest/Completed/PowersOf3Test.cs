using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class PowersOf3Test
{
    [Test]
    public void SampleTest()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(PowersOf3.LargestPower(3), Is.Zero);
            Assert.That(PowersOf3.LargestPower(4), Is.EqualTo(1));
            Assert.That(PowersOf3.LargestPower(1), Is.EqualTo(-1));
        }
    }
}
