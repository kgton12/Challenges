using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class TransformToPrimeTest
{
    [Test]
    public void BasicTests()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(TransformToPrime.MinimumNumber([3, 1, 2]), Is.EqualTo(1));
            Assert.That(TransformToPrime.MinimumNumber([5, 2]), Is.Zero);
            Assert.That(TransformToPrime.MinimumNumber([1, 1, 1]), Is.Zero);
            Assert.That(TransformToPrime.MinimumNumber([2, 12, 8, 4, 6]), Is.EqualTo(5));
            Assert.That(TransformToPrime.MinimumNumber([50, 39, 49, 6, 17, 28]), Is.EqualTo(2));
        }
    }
}
