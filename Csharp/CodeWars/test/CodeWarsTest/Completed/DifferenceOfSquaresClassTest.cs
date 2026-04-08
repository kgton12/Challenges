using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class DifferenceOfSquaresClassTest
{
    [Test]
    [TestCase(5, ExpectedResult = 170)]
    [TestCase(10, ExpectedResult = 2640)]
    [TestCase(100, ExpectedResult = 25164150)]
    public static int FixedTest(int x)
    {
        return DifferenceOfSquaresClass.DifferenceOfSquares(x);
    }
}
