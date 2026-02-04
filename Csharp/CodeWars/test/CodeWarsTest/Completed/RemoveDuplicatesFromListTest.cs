using CodeWars.Resolutions;

namespace CodeWarsTest.Completed;

public class RemoveDuplicatesFromListTest
{
    [Test]
    public void MyTest()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(RemoveDuplicatesFromList.distinct([1]), Is.EqualTo([1]));
            Assert.That(RemoveDuplicatesFromList.distinct([1, 2]), Is.EqualTo([1, 2]));
            Assert.That(RemoveDuplicatesFromList.distinct([1, 1, 2]), Is.EqualTo([1, 2]));
        }
    }
}
