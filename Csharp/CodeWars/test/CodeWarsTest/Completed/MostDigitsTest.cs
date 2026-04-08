using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class MostDigitsTest
{
    [Test]
    public void SampleTest()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(MostDigits.FindLongest([1, 10, 100]), Is.EqualTo(100));
            Assert.That(MostDigits.FindLongest([9000, 8, 800]), Is.EqualTo(9000));
            Assert.That(MostDigits.FindLongest([8, 900, 500]), Is.EqualTo(900));
        }
    }
}
