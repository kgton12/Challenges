using CodeWars.Resolutions;

namespace CodeWarsTest.Completed;

public class SayHelloTest
{
    [Test]
    public void MyTest()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(SayHello.Greet("Niks"), Is.EqualTo("hello Niks!"));
            Assert.That(SayHello.Greet(""), Is.Null);
            Assert.That(SayHello.Greet(null), Is.Null);
        }
    }
}
