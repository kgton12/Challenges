using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class CompleteThePattern6OddLadderTest
{
    [Test]
    public void Test_3()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(CompleteThePattern6OddLadder.OddLadder(4), Is.EqualTo("1\n333"), "Nope!");
            Assert.That(CompleteThePattern6OddLadder.OddLadder(7), Is.EqualTo("1\n333\n55555\n7777777"), "Nope!");
            Assert.That(CompleteThePattern6OddLadder.OddLadder(10), Is.EqualTo("1\n333\n55555\n7777777\n999999999"), "Nope!");
        }
    }
}
