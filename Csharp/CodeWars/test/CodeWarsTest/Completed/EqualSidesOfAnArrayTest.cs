using CodeWars.Resolutions;

namespace CodeWarsTest.Completed;

public class EqualSidesOfAnArrayTest
{
    [Test]
    public void GenericTests()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(EqualSidesOfAnArray.FindEvenIndex([1, 2, 3, 4, 3, 2, 1]), Is.EqualTo(3));
            Assert.That(EqualSidesOfAnArray.FindEvenIndex([1, 100, 50, -51, 1, 1]), Is.EqualTo(1));
            Assert.That(EqualSidesOfAnArray.FindEvenIndex([1, 2, 3, 4, 5, 6]), Is.EqualTo(-1));
            Assert.That(EqualSidesOfAnArray.FindEvenIndex([20, 10, 30, 10, 10, 15, 35]), Is.EqualTo(3));
        }
    }
}
