using CodeWars;

namespace CodeWarsTest;

public class SimpleArrayProductTest
{
    [Test]
    public void ExampleTests()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(SimpleArrayProduct.Solve([[1, 2], [3, 4]]), Is.EqualTo(8));
            Assert.That(SimpleArrayProduct.Solve([[10, -15], [-1, -3]]), Is.EqualTo(45));
            Assert.That(SimpleArrayProduct.Solve([[-1, 2, -3, 4], [1, -2, 3, -4]]), Is.EqualTo(12));
            Assert.That(SimpleArrayProduct.Solve([[-11, -6], [-20, -20], [18, -4], [-20, 1]]), Is.EqualTo(17600));
            Assert.That(SimpleArrayProduct.Solve([[14, 2], [0, -16], [-12, -16]]), Is.EqualTo(3584));
            Assert.That(SimpleArrayProduct.Solve([[-3, -4], [1, 2, -3]]), Is.EqualTo(12));
            Assert.That(SimpleArrayProduct.Solve([[-2, -15, -12, -8, -16], [-4, -15, -7], [-10, -5]]), Is.EqualTo(-40));
        }
    }
}
