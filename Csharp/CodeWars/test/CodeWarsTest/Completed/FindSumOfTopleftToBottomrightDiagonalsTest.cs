using CodeWars.Resolutions;

namespace CodeWarsTest.Completed;

public class FindSumOfTopleftToBottomrightDiagonalsTest
{
    [Test, Order(1)]
    public void SampleTest()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(FindSumOfTopleftToBottomrightDiagonals.DiagonalSum(new int[,] { { 12 } }), Is.EqualTo(12));
            Assert.That(FindSumOfTopleftToBottomrightDiagonals.DiagonalSum(new int[2, 2] { { 1, 2 }, { 3, 4 } }), Is.EqualTo(5));
            Assert.That(FindSumOfTopleftToBottomrightDiagonals.DiagonalSum(new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } }), Is.EqualTo(15));
            Assert.That(FindSumOfTopleftToBottomrightDiagonals.DiagonalSum(new int[,] { { 1, 2, 3, 4 }, { 5, 6, 7, 8 }, { 9, 10, 11, 12 }, { 13, 14, 15, 16 } }), Is.EqualTo(34));
        }
    }
}
