using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class ExesAndOhsTest
{
    [Test]
    [Order(1)]
    public void ExampleTests()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(ExesAndOhs.XO("xo"), Is.True);
            Assert.That(ExesAndOhs.XO("xxOo"), Is.True);
            Assert.That(ExesAndOhs.XO("xxxm"), Is.False);
            Assert.That(ExesAndOhs.XO("Oo"), Is.False);
            Assert.That(ExesAndOhs.XO("ooom"), Is.False);
        }
    }
}
