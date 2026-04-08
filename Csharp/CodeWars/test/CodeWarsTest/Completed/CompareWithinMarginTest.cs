using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class CompareWithinMarginTest
{
    [Test]
    public void BasicTests()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(CompareWithinMargin.CloseCompare(4, 5), Is.EqualTo(-1));
            Assert.That(CompareWithinMargin.CloseCompare(5, 5), Is.Zero);
            Assert.That(CompareWithinMargin.CloseCompare(6, 5), Is.EqualTo(1));
            Assert.That(CompareWithinMargin.CloseCompare(-6, -5), Is.EqualTo(-1));

            Assert.That(CompareWithinMargin.CloseCompare(2, 5, 3), Is.Zero);
            Assert.That(CompareWithinMargin.CloseCompare(8.1, 5, 3), Is.EqualTo(1));
            Assert.That(CompareWithinMargin.CloseCompare(1.99, 5, 3), Is.EqualTo(-1));
        }
    }
}
