using CodeWars.Resolutions;

namespace CodeWarsTest.Completed;

public class NiceArrayTest
{
    [Test]
    public void SampleTest()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(NiceArray.IsNice([2, 10, 9, 3]), Is.True);
            Assert.That(NiceArray.IsNice([3, 4, 5, 7]), Is.False);
        }
    }
}
