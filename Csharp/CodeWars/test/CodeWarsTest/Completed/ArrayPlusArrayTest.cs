using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class ArrayPlusArrayTest
{
    [Test]
    public void BasicTest()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(ArrayPlusArrayClass.ArrayPlusArray([1, 2, 3], [4, 5, 6]), Is.EqualTo(21));
            Assert.That(ArrayPlusArrayClass.ArrayPlusArray([-1, -2, -3], [-4, -5, -6]), Is.EqualTo(-21));
            Assert.That(ArrayPlusArrayClass.ArrayPlusArray([0, 0, 0], [4, 5, 6]), Is.EqualTo(15));
            Assert.That(ArrayPlusArrayClass.ArrayPlusArray([100, 200, 300], [400, 500, 600]), Is.EqualTo(2100));
        }

    }
}
