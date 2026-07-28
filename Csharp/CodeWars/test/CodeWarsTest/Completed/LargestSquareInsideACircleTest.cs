using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class LargestSquareInsideACircleTest
{
    [Test]
    public void AreaLargestSquareTest()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(LargestSquareInsideACircle.AreaLargestSquare(5), Is.EqualTo(50));
            Assert.That(LargestSquareInsideACircle.AreaLargestSquare(7), Is.EqualTo(98));
            Assert.That(LargestSquareInsideACircle.AreaLargestSquare(15), Is.EqualTo(450));
        }
    }
}
