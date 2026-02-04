using CodeWars.Resolutions;

namespace CodeWarsTest.Completed;

public class FibonacciTest
{
    [Test]
    public void MyTest()
    {
        Assert.That(Fibonacci.Fib(5), Is.EqualTo(5));
        Assert.That(Fibonacci.Fib(10), Is.EqualTo(55));
    }
}
