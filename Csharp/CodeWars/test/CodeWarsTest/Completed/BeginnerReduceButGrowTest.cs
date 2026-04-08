using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class BeginnerReduceButGrowTest
{
    [Test]
    [Order(1)]
    public void BasicTests()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(BeginnerReduceButGrow.Grow([1, 2, 3]), Is.EqualTo(6));
            Assert.That(BeginnerReduceButGrow.Grow([4, 1, 1, 1, 4]), Is.EqualTo(16));
            Assert.That(BeginnerReduceButGrow.Grow([2, 2, 2, 2, 2, 2]), Is.EqualTo(64));
        }
    }
}
