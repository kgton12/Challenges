using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class AlphabetWarClassTest
{
    [Test]
    public void BasicTest()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(AlphabetWarClass.AlphabetWar("z"), Is.EqualTo("Right side wins!"));
            Assert.That(AlphabetWarClass.AlphabetWar("zdqmwpbs"), Is.EqualTo("Let's fight again!"));
            Assert.That(AlphabetWarClass.AlphabetWar("zzzzs"), Is.EqualTo("Right side wins!"));
            Assert.That(AlphabetWarClass.AlphabetWar("wwwwwwz"), Is.EqualTo("Left side wins!"));
        }
    }
}
