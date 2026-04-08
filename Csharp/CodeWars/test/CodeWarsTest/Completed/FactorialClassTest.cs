using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class FactorialClassTest
{
    [Test, Order(1)]
    public void FactorialOf0ShouldBe1()
    {
        Assert.That(FactorialClass.Factorial(0), Is.EqualTo(1));
    }

    [Test, Order(2)]
    public void FactorialOf1ShouldBe1()
    {
        Assert.That(FactorialClass.Factorial(1), Is.EqualTo(1));
    }

    [Test, Order(3)]
    public void FactorialOf2ShouldBe2()
    {
        Assert.That(FactorialClass.Factorial(2), Is.EqualTo(2));
    }

    [Test, Order(4)]
    public void FactorialOf3ShouldBe6()
    {
        Assert.That(FactorialClass.Factorial(3), Is.EqualTo(6));
    }
}
