using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class TwiceAsOldClassTest
{
    [Test]
    public void SampleTests()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(TwiceAsOldClass.TwiceAsOld(30, 0), Is.EqualTo(30));
            Assert.That(TwiceAsOldClass.TwiceAsOld(30, 7), Is.EqualTo(16));
            Assert.That(TwiceAsOldClass.TwiceAsOld(45, 30), Is.EqualTo(15));
        }
    }
}
