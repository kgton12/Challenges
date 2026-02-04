using CodeWars.Resolutions;

namespace CodeWarsTest.Completed;

public class EnumerableMagic4TrueForNoneTest
{

    [Test]
    public void BasicTests()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(EnumerableMagic4TrueForNone.None(new int[] { 1, 2, 3, 4, 5 }, v => v > 5), Is.True);
            Assert.That(EnumerableMagic4TrueForNone.None(new int[] { 1, 2, 3, 4, 5 }, v => v > 4), Is.False);
        }
    }
}
