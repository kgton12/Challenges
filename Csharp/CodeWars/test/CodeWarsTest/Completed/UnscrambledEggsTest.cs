using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class UnscrambledEggsTest
{
    [Test]
    public void BasicTest()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(UnscrambledEggs.UnscrambleEggs("ceggodegge heggeregge"), Is.EqualTo("code here"));
            Assert.That(UnscrambledEggs.UnscrambleEggs("FeggUNegg KeggATeggA"), Is.EqualTo("FUN KATA"));
        }
    }
}
