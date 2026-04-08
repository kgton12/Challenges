using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class AreaOfACircleTest
{
    [Test, Order(1)]
    public void TestPositiveNumber()
    {
        Assert.That(AreaOfACircle.CalculateAreaOfCircle(1), Is.EqualTo(3.141).Within(0.01));
    }

    [Test, Order(2)]
    public void TestExamples()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(AreaOfACircle.CalculateAreaOfCircle(43.2673), Is.EqualTo(5881.248).Within(0.01));
            Assert.That(AreaOfACircle.CalculateAreaOfCircle(68), Is.EqualTo(14526.724).Within(0.01));
        }
    }

    [Test, Order(3)]
    public void TestZero()
    {
        Assert.That(() => AreaOfACircle.CalculateAreaOfCircle(0), Throws.TypeOf<ArgumentException>());
    }

    [Test, Order(4)]
    public void TestNegativeNumber()
    {
        Assert.That(() => AreaOfACircle.CalculateAreaOfCircle(-1), Throws.TypeOf<ArgumentException>());
    }
}
