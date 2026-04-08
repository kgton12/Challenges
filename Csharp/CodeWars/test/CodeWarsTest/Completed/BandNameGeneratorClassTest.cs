using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class BandNameGeneratorClassTest
{
    [Test]
    public void SampleTest()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(BandNameGeneratorClass.BandNameGenerator("knife"), Is.EqualTo("The Knife"));
            Assert.That(BandNameGeneratorClass.BandNameGenerator("tart"), Is.EqualTo("Tartart"));
            Assert.That(BandNameGeneratorClass.BandNameGenerator("sandles"), Is.EqualTo("Sandlesandles"));
            Assert.That(BandNameGeneratorClass.BandNameGenerator("bed"), Is.EqualTo("The Bed"));
        }
    }
}
