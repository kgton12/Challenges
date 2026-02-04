using CodeWars.Resolutions;

namespace CodeWarsTest.Completed;

public class SimpleFun37HouseNumbersSumTest
{
    [Test]
    public void BasicTests()
    {
        Assert.That(SimpleFun37HouseNumbersSum.HouseNumbersSum(new int[] { 5, 1, 2, 3, 0, 1, 5, 0, 2 }), Is.EqualTo(11));
        Assert.That(SimpleFun37HouseNumbersSum.HouseNumbersSum(new int[] { 4, 2, 1, 6, 0 }), Is.EqualTo(13));
        Assert.That(SimpleFun37HouseNumbersSum.HouseNumbersSum(new int[] { 4, 1, 2, 3, 0, 10, 2 }), Is.EqualTo(10));
        Assert.That(SimpleFun37HouseNumbersSum.HouseNumbersSum(new int[] { 0, 1, 2, 3, 4, 5 }), Is.EqualTo(0));
    }
}
