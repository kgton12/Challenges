using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class BeginnerSeries5TriangularNumbersTest
{
    [Test]
    public void TrueTriangularTests()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(BeginnerSeries5TriangularNumbers.IsTriangular(1), Is.True);
            Assert.That(BeginnerSeries5TriangularNumbers.IsTriangular(3), Is.True);
            Assert.That(BeginnerSeries5TriangularNumbers.IsTriangular(6), Is.True);
            Assert.That(BeginnerSeries5TriangularNumbers.IsTriangular(10), Is.True);
            Assert.That(BeginnerSeries5TriangularNumbers.IsTriangular(15), Is.True);
            Assert.That(BeginnerSeries5TriangularNumbers.IsTriangular(21), Is.True);
            Assert.That(BeginnerSeries5TriangularNumbers.IsTriangular(28), Is.True);
            Assert.That(BeginnerSeries5TriangularNumbers.IsTriangular(36), Is.True);
            Assert.That(BeginnerSeries5TriangularNumbers.IsTriangular(45), Is.True);
            Assert.That(BeginnerSeries5TriangularNumbers.IsTriangular(55), Is.True);
            Assert.That(BeginnerSeries5TriangularNumbers.IsTriangular(2147450880), Is.True);
        }
    }

    [Test]
    public void FalseTriangularTests()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(BeginnerSeries5TriangularNumbers.IsTriangular(2), Is.False);
            Assert.That(BeginnerSeries5TriangularNumbers.IsTriangular(4), Is.False);
            Assert.That(BeginnerSeries5TriangularNumbers.IsTriangular(5), Is.False);
            Assert.That(BeginnerSeries5TriangularNumbers.IsTriangular(7), Is.False);
            Assert.That(BeginnerSeries5TriangularNumbers.IsTriangular(8), Is.False);
            Assert.That(BeginnerSeries5TriangularNumbers.IsTriangular(9), Is.False);
            Assert.That(BeginnerSeries5TriangularNumbers.IsTriangular(11), Is.False);
            Assert.That(BeginnerSeries5TriangularNumbers.IsTriangular(12), Is.False);
            Assert.That(BeginnerSeries5TriangularNumbers.IsTriangular(13), Is.False);
            Assert.That(BeginnerSeries5TriangularNumbers.IsTriangular(14), Is.False);
        }
    }
}