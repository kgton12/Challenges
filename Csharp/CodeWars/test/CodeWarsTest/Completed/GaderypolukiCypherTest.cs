using CodeWars.Resolutions;

namespace CodeWarsTest.Completed;

public class GaderypolukiCypherTest
{
    [Test]
    public void BasicTest()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(GaderypolukiCypher.Encode("Ala has a cat"), Is.EqualTo("Gug hgs g cgt"));
            Assert.That(GaderypolukiCypher.Encode("ABCD"), Is.EqualTo("GBCE"));
        }

        using (Assert.EnterMultipleScope())
        {
            Assert.That(GaderypolukiCypher.Encode("Ala has a cat"), Is.EqualTo("Gug hgs g cgt"));
            Assert.That(GaderypolukiCypher.Encode("gaderypoluki"), Is.EqualTo("agedyropulik"));
            Assert.That(GaderypolukiCypher.Decode("Gug hgs g cgt"), Is.EqualTo("Ala has a cat"));
            Assert.That(GaderypolukiCypher.Decode("agedyropulik"), Is.EqualTo("gaderypoluki"));
            Assert.That(GaderypolukiCypher.Decode("GBCE"), Is.EqualTo("ABCD"));
        }
    }
}