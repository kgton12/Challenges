using CodeWars.Resolutions;

namespace CodeWarsTest.Completed;

public class SumOfTriangularNumbersTest
{
    [Test]
    public void BasicTests()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(SumOfTriangularNumbers.SumTriangularNumbers(6), Is.EqualTo(56));
            Assert.That(SumOfTriangularNumbers.SumTriangularNumbers(34), Is.EqualTo(7140));
            Assert.That(SumOfTriangularNumbers.SumTriangularNumbers(-291), Is.Zero);
            Assert.That(SumOfTriangularNumbers.SumTriangularNumbers(943), Is.EqualTo(140205240));
            Assert.That(SumOfTriangularNumbers.SumTriangularNumbers(-971), Is.Zero);
        }
    }
}
