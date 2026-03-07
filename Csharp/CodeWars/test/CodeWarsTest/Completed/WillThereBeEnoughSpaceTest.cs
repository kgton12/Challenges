using CodeWars.Resolutions;

namespace CodeWarsTest.Completed;

public class WillThereBeEnoughSpaceTest
{
    [Test]
    public void SampleTest()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(WillThereBeEnoughSpace.Enough(10, 5, 5), Is.Zero);
            Assert.That(WillThereBeEnoughSpace.Enough(100, 60, 50), Is.EqualTo(10));
            Assert.That(WillThereBeEnoughSpace.Enough(20, 5, 5), Is.Zero);
        }
    }
}
