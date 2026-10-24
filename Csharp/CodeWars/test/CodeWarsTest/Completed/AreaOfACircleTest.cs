using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class AreaOfACircleTest
{
    [Test]
    public void TestPositiveNumber()
    {
        Assert.That(AreaOfACircle.CalculateAreaOfCircle(1), Is.EqualTo(3.141).Within(0.01));
    }

    [Test]
    public void TestExamples()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(AreaOfACircle.CalculateAreaOfCircle(43.2673), Is.EqualTo(5881.248).Within(0.01));
            Assert.That(AreaOfACircle.CalculateAreaOfCircle(68), Is.EqualTo(14526.724).Within(0.01));
        }
    }

    [Test]
    public void TestZero()
    {
        Assert.That(() => AreaOfACircle.CalculateAreaOfCircle(0), Throws.TypeOf<ArgumentException>());
    }

    [Test]
    public void TestNegativeNumber()
    {
        Assert.That(() => AreaOfACircle.CalculateAreaOfCircle(-1), Throws.TypeOf<ArgumentException>());
    }
}
