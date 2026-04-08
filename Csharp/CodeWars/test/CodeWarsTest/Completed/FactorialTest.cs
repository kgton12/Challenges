using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class FactorialTest
{
    [Test]
    public void Tests()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(FactorialClass.Factorial(0), Is.EqualTo(1));
            Assert.That(FactorialClass.Factorial(1), Is.EqualTo(1));
            Assert.That(FactorialClass.Factorial(2), Is.EqualTo(2));
            Assert.That(FactorialClass.Factorial(3), Is.EqualTo(6));
            Assert.That(FactorialClass.Factorial(4), Is.EqualTo(24));
            Assert.That(FactorialClass.Factorial(5), Is.EqualTo(120));
        }
    }
}
