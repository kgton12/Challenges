using CodeWars.Resolutions;

namespace CodeWarsTest.Completed;

public class TemplateStringsTest
{
    [Test]
    public void TempleStrings()
    {
        Assert.That(TemplateStrings.TempleStrings("Animals", "Good"), Is.EqualTo("Animals are Good"));
    }
}
