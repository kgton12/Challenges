using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class SuitcasePackingTest
{
    [Test]
    public void FixedTests()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(SuitcasePacking.FitSquares(1, 2, 3, 2), Is.True);
            Assert.That(SuitcasePacking.FitSquares(1, 2, 2, 1), Is.False);
            Assert.That(SuitcasePacking.FitSquares(3, 2, 3, 2), Is.False);
            Assert.That(SuitcasePacking.FitSquares(1, 2, 1, 2), Is.False);
            Assert.That(SuitcasePacking.FitSquares(6, 5, 8, 7), Is.False);
        }
    }
}
