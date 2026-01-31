using CodeWars.Resolutions;

namespace CodeWarsTest.Completed;

public class NiceArrayTest
{
    [Test]
    public void SampleTest()
    {
        Assert.That(NiceArray.IsNice(new int[] { 2, 10, 9, 3 }), Is.EqualTo(true));
        Assert.That(NiceArray.IsNice(new int[] { 3, 4, 5, 7 }), Is.EqualTo(false));
    }
}
