using CodeWars.Resolutions;

namespace CodeWarsTest;

public class OperationsWithSequenceTest
{
    [TestCase(31, new[] { 0, 2, 1, -6, -3, 3 })]
    [TestCase(0, new[] { 0 })]
    [TestCase(5, new[] { 1, 1, 1, 1, 1 })]
    public void BasicTests(int expected, int[] actual)
    {
        Assert.That(OperationsWithSequence.Calc(actual), Is.EqualTo(expected));
    }
}
