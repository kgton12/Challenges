using CodeWars.Completed;

namespace CodeWarsTest.Completed;

[TestFixture]
public class SimpleFun3LateRideTest
{
    [Test]
    public void TestCase()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(SimpleFun3LateRide.LateRide(240), Is.EqualTo(4));
            Assert.That(SimpleFun3LateRide.LateRide(808), Is.EqualTo(14));
            Assert.That(SimpleFun3LateRide.LateRide(1439), Is.EqualTo(19));
            Assert.That(SimpleFun3LateRide.LateRide(0), Is.Zero);
            Assert.That(SimpleFun3LateRide.LateRide(23), Is.EqualTo(5));
            Assert.That(SimpleFun3LateRide.LateRide(8), Is.EqualTo(8));
        }
    }
}