using CodeWars.Resolutions;

namespace CodeWarsTest.Completed;

public class BattleOfTheCharactersEasyTest
{
    [Test]
    public void BasicTests()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(BattleOfTheCharactersEasy.Battle("AAA", "Z"), Is.EqualTo("Z"));
            Assert.That(BattleOfTheCharactersEasy.Battle("ONE", "TWO"), Is.EqualTo("TWO"));
            Assert.That(BattleOfTheCharactersEasy.Battle("ONE", "NEO"), Is.EqualTo("Tie!"));
            Assert.That(BattleOfTheCharactersEasy.Battle("FOUR", "FIVE"), Is.EqualTo("FOUR"));
        }
    }
}
