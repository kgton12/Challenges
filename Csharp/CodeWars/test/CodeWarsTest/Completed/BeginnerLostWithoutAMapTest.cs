using CodeWars.Resolutions;

namespace CodeWarsTest.Completed;

public class BeginnerLostWithoutAMapTest
{
    [Test]
    public void BasicTests()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(BeginnerLostWithoutAMap.Maps([1, 2, 3]), Is.EqualTo([2, 4, 6]));
            Assert.That(BeginnerLostWithoutAMap.Maps([4, 1, 1, 1, 4]), Is.EqualTo([8, 2, 2, 2, 8]));
            Assert.That(BeginnerLostWithoutAMap.Maps([2, 2, 2, 2, 2, 2]), Is.EqualTo([4, 4, 4, 4, 4, 4]));
        }
    }
}
