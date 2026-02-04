using CodeWars.Resolutions;

namespace CodeWarsTest.Completed;

public class BattleOfTheCharactersMediumTest
{
    [Test]
    public void SampleTests()
    {
        Assert.That(BattleOfTheCharactersMedium.Battle("One", "Two"), Is.EqualTo("Two"));
        Assert.That(BattleOfTheCharactersMedium.Battle("One", "Neo"), Is.EqualTo("One"));
        Assert.That(BattleOfTheCharactersMedium.Battle("One", "neO"), Is.EqualTo("Tie!"));
        Assert.That(BattleOfTheCharactersMedium.Battle("Foo", "BAR"), Is.EqualTo("Tie!"));
        Assert.That(BattleOfTheCharactersMedium.Battle("Four", "Five"), Is.EqualTo("Four"));
    }
}
