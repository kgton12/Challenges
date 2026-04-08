using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class TwoFightersOneWinnerTest
{
    [Test]
    public void BasicTests()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(TwoFightersOneWinner.DeclareWinner(new Fighter("Lew", 10, 2), new Fighter("Harry", 5, 4), "Lew"), Is.EqualTo("Lew"));
            Assert.That(TwoFightersOneWinner.DeclareWinner(new Fighter("Lew", 10, 2), new Fighter("Harry", 5, 4), "Harry"), Is.EqualTo("Harry"));
            Assert.That(TwoFightersOneWinner.DeclareWinner(new Fighter("Harald", 20, 5), new Fighter("Harry", 5, 4), "Harry"), Is.EqualTo("Harald"));
            Assert.That(TwoFightersOneWinner.DeclareWinner(new Fighter("Harald", 20, 5), new Fighter("Harry", 5, 4), "Harald"), Is.EqualTo("Harald"));
            Assert.That(TwoFightersOneWinner.DeclareWinner(new Fighter("Jerry", 30, 3), new Fighter("Harald", 20, 5), "Jerry"), Is.EqualTo("Harald"));
            Assert.That(TwoFightersOneWinner.DeclareWinner(new Fighter("Jerry", 30, 3), new Fighter("Harald", 20, 5), "Harald"), Is.EqualTo("Harald"));
        }
    }
}
