using CodeWars.Resolutions;

namespace CodeWarsTest;

public class NameShufflerClassTest
{
    [Test, Description("Sample Tests")]
    public void SampleTest()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(NameShufflerClass.NameShuffler("john McClane"), Is.EqualTo("McClane john"));
            Assert.That(NameShufflerClass.NameShuffler("Mary jeggins"), Is.EqualTo("jeggins Mary"));
            Assert.That(NameShufflerClass.NameShuffler("tom jerry"), Is.EqualTo("jerry tom"));
        }
    }
}
