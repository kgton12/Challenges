using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class SimpleRemoveDuplicatesTest
{
    [Test]
    public void ExampleTests()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(SimpleRemoveDuplicates.Solve([3, 4, 4, 3, 6, 3]), Is.EqualTo([4, 6, 3]));
            Assert.That(SimpleRemoveDuplicates.Solve([1, 2, 1, 2, 1, 2, 3]), Is.EqualTo([1, 2, 3]));
            Assert.That(SimpleRemoveDuplicates.Solve([1, 2, 3, 4]), Is.EqualTo([1, 2, 3, 4]));
            Assert.That(SimpleRemoveDuplicates.Solve([1, 1, 4, 5, 1, 2, 1]), Is.EqualTo([4, 5, 2, 1]));
        }
    }
}
