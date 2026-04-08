using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class SimpleFun37HouseNumbersSumTest
{
    [Test]
    public void BasicTests()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(SimpleFun37HouseNumbersSum.HouseNumbersSum([5, 1, 2, 3, 0, 1, 5, 0, 2]), Is.EqualTo(11));
            Assert.That(SimpleFun37HouseNumbersSum.HouseNumbersSum([4, 2, 1, 6, 0]), Is.EqualTo(13));
            Assert.That(SimpleFun37HouseNumbersSum.HouseNumbersSum([4, 1, 2, 3, 0, 10, 2]), Is.EqualTo(10));
            Assert.That(SimpleFun37HouseNumbersSum.HouseNumbersSum([0, 1, 2, 3, 4, 5]), Is.EqualTo(0));
        }
    }
}
