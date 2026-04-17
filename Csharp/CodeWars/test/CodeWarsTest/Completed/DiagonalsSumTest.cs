using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class DiagonalsSumTest
{
    [Test]
    public void BasicTests()
    {
        Assert.That(DiagonalsSum.SumDiagonals(new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } }), Is.EqualTo(1 + 5 + 9 + 3 + 5 + 7));
    }
}
