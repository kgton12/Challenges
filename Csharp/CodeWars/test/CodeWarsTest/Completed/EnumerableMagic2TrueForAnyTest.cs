using CodeWars.Resolutions;

namespace CodeWarsTest.Completed;

public class EnumerableMagic2TrueForAnyTest
{
    [Test]
    public void BasicTest()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(EnumerableMagic2TrueForAny.Any([1, 2, 3, 4], v => v > 3), Is.True);
            Assert.That(EnumerableMagic2TrueForAny.Any([1, 2, 3, 4], v => v > 4), Is.False);
        }
    }
}
