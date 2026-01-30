using CodeWars.Resolutions;

namespace CodeWarsTest.Completed;

public class BorrowerSpeakTest
{
    [Test]
    public void BasicTests()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(BorrowerSpeak.Borrow("WhAt! FiCK! DaMn CAke?"), Is.EqualTo("whatfickdamncake"));
            Assert.That(BorrowerSpeak.Borrow("THE big PeOpLE Here!!"), Is.EqualTo("thebigpeoplehere"));
            Assert.That(BorrowerSpeak.Borrow("i AM a TINY BoY!!"), Is.EqualTo("iamatinyboy"));
        }
    }
}
