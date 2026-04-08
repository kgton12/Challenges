using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class NameArrayCappingTest
{
    [Test]
    public void SampleTest()
    {
        Assert.That(NameArrayCapping.CapMe(["ExPeCteD"]), Is.EqualTo(["Expected"]));
    }
}
