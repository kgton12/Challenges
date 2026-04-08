using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class EnumerableMagic1TrueForAllTest
{
    [Test]
    public void BasicTest()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(EnumerableMagic1TrueForAll.All([1, 2, 3, 4, 5], v => v < 9), Is.True);
            Assert.That(EnumerableMagic1TrueForAll.All([1, 2, 3, 4, 5], v => v > 9), Is.False);
        }
    }
}
