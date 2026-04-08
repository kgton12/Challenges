using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class WillYouMakeItTest
{
    [Test]
    [Order(1)]
    public void SampleTest()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(WillYouMakeIt.ZeroFuel(50, 25, 2), Is.True);
            Assert.That(WillYouMakeIt.ZeroFuel(100, 50, 1), Is.False);
        }
    }
}
