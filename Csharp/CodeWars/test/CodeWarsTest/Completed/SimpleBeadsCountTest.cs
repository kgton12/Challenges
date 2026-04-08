using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class SimpleBeadsCountTest
{
    [Test, Description("Basic Tests")]
    public void SampleTest()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(SimpleBeadsCount.CountRedBeads(0), Is.Zero);
            Assert.That(SimpleBeadsCount.CountRedBeads(1), Is.Zero);
            Assert.That(SimpleBeadsCount.CountRedBeads(3), Is.EqualTo(4));
            Assert.That(SimpleBeadsCount.CountRedBeads(5), Is.EqualTo(8));
        }
    }
}
