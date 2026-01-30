using CodeWars.Resolutions;

namespace CodeWarsTest.Completed;

public class HelloNameOrWorldTest
{
    [Test]
    public void BasicTest()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(HelloNameOrWorld.Hello("jEFF"), Is.EqualTo("Hello, Jeff!"));
            Assert.That(HelloNameOrWorld.Hello("tonY"), Is.EqualTo("Hello, Tony!"));
            Assert.That(HelloNameOrWorld.Hello("Alicia"), Is.EqualTo("Hello, Alicia!"));
            Assert.That(HelloNameOrWorld.Hello("vasya"), Is.EqualTo("Hello, Vasya!"));
            Assert.That(HelloNameOrWorld.Hello("JOHN"), Is.EqualTo("Hello, John!"));
            Assert.That(HelloNameOrWorld.Hello(""), Is.EqualTo("Hello, World!"));
        }
    }

    [Test]
    public void NoArgumentTest()
    {
        Assert.That(HelloNameOrWorld.Hello(), Is.EqualTo("Hello, World!"));
    }
}
