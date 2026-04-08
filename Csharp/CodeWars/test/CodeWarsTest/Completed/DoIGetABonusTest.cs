using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class DoIGetABonusTest
{
    [Test]
    public void BasicTest()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(DoIGetABonus.BonusTime(10000, true), Is.EqualTo("$100000").IgnoreCase);
            Assert.That(DoIGetABonus.BonusTime(25000, true), Is.EqualTo("$250000").IgnoreCase);
            Assert.That(DoIGetABonus.BonusTime(10000, false), Is.EqualTo("$10000").IgnoreCase);
            Assert.That(DoIGetABonus.BonusTime(60000, false), Is.EqualTo("$60000").IgnoreCase);
            Assert.That(DoIGetABonus.BonusTime(2, true), Is.EqualTo("$20").IgnoreCase);
            Assert.That(DoIGetABonus.BonusTime(78, false), Is.EqualTo("$78").IgnoreCase);
            Assert.That(DoIGetABonus.BonusTime(67890, true), Is.EqualTo("$678900").IgnoreCase);
        }
    }
}
