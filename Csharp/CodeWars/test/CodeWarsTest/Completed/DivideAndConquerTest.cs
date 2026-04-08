using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class DivideAndConquerTest
{
    [Test, Order(1)]
    public void SampleTest()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(DivideAndConquer.DivCon([9, 3, "7", "3"]), Is.EqualTo(2));
            Assert.That(DivideAndConquer.DivCon(["5", "0", 9, 3, 2, 1, "9", 6, 7]), Is.EqualTo(14));
            Assert.That(DivideAndConquer.DivCon(["3", 6, 6, 0, "5", 8, 5, "6", 2, "0"]), Is.EqualTo(13));
            Assert.That(DivideAndConquer.DivCon(["1", "5", "8", 8, 9, 9, 2, "3"]), Is.EqualTo(11));
            Assert.That(DivideAndConquer.DivCon([8, 0, 0, 8, 5, 7, 2, 3, 7, 8, 6, 7]), Is.EqualTo(61));
            Assert.That(DivideAndConquer.DivCon(["0", "1", "2", "3"]), Is.EqualTo(-6));
            Assert.That(DivideAndConquer.DivCon([0, 1, 2, 3]), Is.EqualTo(6));
            Assert.That(DivideAndConquer.DivCon([1, "1"]), Is.EqualTo(0));
            Assert.That(DivideAndConquer.DivCon([-1, "1"]), Is.EqualTo(-2));
            Assert.That(DivideAndConquer.DivCon([1, "-1"]), Is.EqualTo(2));
            Assert.That(DivideAndConquer.DivCon([1]), Is.EqualTo(1));
            Assert.That(DivideAndConquer.DivCon(["1"]), Is.EqualTo(-1));
            Assert.That(DivideAndConquer.DivCon([]), Is.EqualTo(0));
        }
    }
}
