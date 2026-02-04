using CodeWars.Resolutions;

namespace CodeWarsTest.Completed;

public class DigitalCypherTest
{
    [Test]
    public void BasicTest()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(DigitalCypher.Encode("scout", 1939), Is.EqualTo([20, 12, 18, 30, 21]));
            Assert.That(DigitalCypher.Encode("masterpiece", 1939), Is.EqualTo([14, 10, 22, 29, 6, 27, 19, 18, 6, 12, 8]));
        }

    }
}
