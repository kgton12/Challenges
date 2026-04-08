using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class AlphabetWarAirstrikeLettersMassacreTest
{
    [Test]
    public void BasicTests()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(AlphabetWarAirstrikeLettersMassacre.AlphabetWar("z"), Is.EqualTo("Right side wins!"));
            Assert.That(AlphabetWarAirstrikeLettersMassacre.AlphabetWar("****"), Is.EqualTo("Let's fight again!"));
            Assert.That(AlphabetWarAirstrikeLettersMassacre.AlphabetWar("z*dq*mw*pb*s"), Is.EqualTo("Let's fight again!"));
            Assert.That(AlphabetWarAirstrikeLettersMassacre.AlphabetWar("zdqmwpbs"), Is.EqualTo("Let's fight again!"));
            Assert.That(AlphabetWarAirstrikeLettersMassacre.AlphabetWar("zz*zzs"), Is.EqualTo("Right side wins!"));
            Assert.That(AlphabetWarAirstrikeLettersMassacre.AlphabetWar("*wwwwww*z*"), Is.EqualTo("Left side wins!"));
            Assert.That(AlphabetWarAirstrikeLettersMassacre.AlphabetWar("*pjo"), Is.EqualTo("Let's fight again!"));
        }
    }
}
