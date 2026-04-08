using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class EnumerableMagic5TrueForJustOneTest
{
    [Test]
    public void BasicTest()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(EnumerableMagic5TrueForJustOne.One([1, 2, 3, 4, 5], v => v < 2), Is.True);
            Assert.That(EnumerableMagic5TrueForJustOne.One([1, 2, 3, 4, 5], v => v % 2 != 0), Is.False);
            Assert.That(EnumerableMagic5TrueForJustOne.One([1, 2, 3, 4, 5], v => v > 5), Is.False);
        }
    }
}
