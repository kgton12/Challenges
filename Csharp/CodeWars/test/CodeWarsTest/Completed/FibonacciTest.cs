using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class FibonacciTest
{
    [Test]
    public void MyTest()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(Fibonacci.Fib(5), Is.EqualTo(5));
            Assert.That(Fibonacci.Fib(10), Is.EqualTo(55));
        }
    }
}
