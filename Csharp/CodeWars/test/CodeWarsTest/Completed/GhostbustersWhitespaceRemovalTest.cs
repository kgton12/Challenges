using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class GhostbustersWhitespaceRemovalTest
{
    [Test]
    public void GenericTests()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(GhostbustersWhitespaceRemoval.GhostBusters("Factor y"), Is.EqualTo("Factory"), "Nope, there may still be a ghost in the building. Try again.");
            Assert.That(GhostbustersWhitespaceRemoval.GhostBusters("O  f fi ce"), Is.EqualTo("Office"), "Nope, there may still be a ghost in the building. Try again.");
            Assert.That(GhostbustersWhitespaceRemoval.GhostBusters("BusStation"), Is.EqualTo("You just wanted my autograph didn't you?"), "Nope, as there were no ghosts in the BusStation you need to return a witty retort.");
        }
    }
}
