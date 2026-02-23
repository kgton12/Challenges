using CodeWars.Resolutions;

namespace CodeWarsTest.Completed;

public class AreThereDoublesTest
{
    [Test]
    public void Test1()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(AreThereDoubles.DoubleCheck("abca"), Is.False);
            Assert.That(AreThereDoubles.DoubleCheck("aabc"), Is.True);
            Assert.That(AreThereDoubles.DoubleCheck("a 11 c d"), Is.True);
            Assert.That(AreThereDoubles.DoubleCheck("AabBcC"), Is.True);
            Assert.That(AreThereDoubles.DoubleCheck("a b  c"), Is.True);
            Assert.That(AreThereDoubles.DoubleCheck("a b c d e f g h i h k"), Is.False);
            Assert.That(AreThereDoubles.DoubleCheck("2020"), Is.False);
            Assert.That(AreThereDoubles.DoubleCheck("a!@€£#$%^&*()_-+=}]{[|\':;?/>.<,~"), Is.False);
        }
    }
}
