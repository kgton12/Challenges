using CodeWars.Resolutions;

namespace CodeWarsTest.Completed;

public class TribonacciSequenceTest
{
    [Test]
    public void Tests()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(TribonacciSequence.Tribonacci(new double[] { 1, 1, 1 }, 10), Is.EqualTo(new double[] { 1, 1, 1, 3, 5, 9, 17, 31, 57, 105 }));
            Assert.That(TribonacciSequence.Tribonacci(new double[] { 0, 0, 1 }, 10), Is.EqualTo(new double[] { 0, 0, 1, 1, 2, 4, 7, 13, 24, 44 }));
            Assert.That(TribonacciSequence.Tribonacci(new double[] { 0, 1, 1 }, 10), Is.EqualTo(new double[] { 0, 1, 1, 2, 4, 7, 13, 24, 44, 81 }));
        }
    }
}
