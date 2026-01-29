using CodeWars.Resolutions;

namespace CodeWarsTest.Completed;

public class DidSheSayHalloTest
{
    [Test]
    public void Test1()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(DidSheSayHallo.ValidateHello("hello"), Is.True);
            Assert.That(DidSheSayHallo.ValidateHello("ciao bella!"), Is.True);
            Assert.That(DidSheSayHallo.ValidateHello("salut"), Is.True);
            Assert.That(DidSheSayHallo.ValidateHello("hallo, salut"), Is.True);
            Assert.That(DidSheSayHallo.ValidateHello("hombre! Hola!"), Is.True);
            Assert.That(DidSheSayHallo.ValidateHello("Hallo, wie geht's dir?"), Is.True);
            Assert.That(DidSheSayHallo.ValidateHello("AHOJ!"), Is.True);
            Assert.That(DidSheSayHallo.ValidateHello("czesc"), Is.True);
            Assert.That(DidSheSayHallo.ValidateHello("Ahoj"), Is.True);
            Assert.That(DidSheSayHallo.ValidateHello("meh"), Is.False);
        }
    }
}
