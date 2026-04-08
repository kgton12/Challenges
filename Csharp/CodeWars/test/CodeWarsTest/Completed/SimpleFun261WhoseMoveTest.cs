using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class SimpleFun261WhoseMoveTest
{
    [Test]
    public void FixedTests()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(SimpleFun261WhoseMove.WhoseMove("black", false), Is.EqualTo("white"));
            Assert.That(SimpleFun261WhoseMove.WhoseMove("white", true), Is.EqualTo("white"));
            Assert.That(SimpleFun261WhoseMove.WhoseMove("white", false), Is.EqualTo("black"));
        }
    }
}
