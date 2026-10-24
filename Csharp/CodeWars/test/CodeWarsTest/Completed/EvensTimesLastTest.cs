using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class EvensTimesLastTest
{
    [Test]
    public void EmptyArrayTest()
    {
        Assert.That(EvensTimesLast.EvenTimesLast(Array.Empty<int>()), Is.Zero);
    }

    [Test]
    public void ArrayWithOneElementTest()
    {
        Assert.That(EvensTimesLast.EvenTimesLast([7]), Is.EqualTo(49));
    }

    [Test]
    public void ArrayWithTwoElementsTest()
    {
        Assert.That(EvensTimesLast.EvenTimesLast([7, 13]), Is.EqualTo(91));
    }

    [Test]
    public void MyTest()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(EvensTimesLast.EvenTimesLast([2, 3, 4, 5]), Is.EqualTo(30));
            Assert.That(EvensTimesLast.EvenTimesLast([2, 3, 4, 5, 0]), Is.Zero);
            Assert.That(EvensTimesLast.EvenTimesLast([2, 3, 4, -1]), Is.EqualTo(-6));
        }
    }
}
