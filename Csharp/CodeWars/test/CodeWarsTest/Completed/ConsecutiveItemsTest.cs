using CodeWars.Resolutions;

namespace CodeWarsTest.Completed;

public class ConsecutiveItemsTest
{
    [Test]
    public void MyTest()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(ConsecutiveItems.Consecutive([1, 3, 5, 7], 3, 7), Is.EqualTo(false));
            Assert.That(ConsecutiveItems.Consecutive([1, 3, 5, 7], 3, 1), Is.EqualTo(true));
            Assert.That(ConsecutiveItems.Consecutive([1, 6, 9, -3, 4, -78, 0], -3, 4), Is.EqualTo(true));
        }
    }
}
