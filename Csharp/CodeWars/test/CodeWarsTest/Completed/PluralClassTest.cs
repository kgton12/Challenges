using CodeWars.Resolutions;

namespace CodeWarsTest.Completed;

public class PluralClassTest
{
    [Test]
    public void BasicTests()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(PluralClass.Plural(0), Is.True, "Plural for 0");
            Assert.That(PluralClass.Plural(0.5), Is.True, "Plural for 0.5");
            Assert.That(PluralClass.Plural(1), Is.False, "Plural for 1");
            Assert.That(PluralClass.Plural(100), Is.True, "Plural for 100");
            Assert.That(PluralClass.Plural(double.PositiveInfinity), Is.True, "Plural for Infinity");
        }
    }
}
