using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class CompleteThePattern5EvenLadderTest
{
    [Test]
    public void BasicTests()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(CompleteThePattern5EvenLadder.Pattern(2), Is.EqualTo("22"));
            Assert.That(CompleteThePattern5EvenLadder.Pattern(1), Is.EqualTo(""));
            Assert.That(CompleteThePattern5EvenLadder.Pattern(5), Is.EqualTo("22\n4444"));
            Assert.That(CompleteThePattern5EvenLadder.Pattern(0), Is.EqualTo(""));
            Assert.That(CompleteThePattern5EvenLadder.Pattern(-25), Is.EqualTo(""));
        }
    }
}
