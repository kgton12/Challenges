using CodeWars.Resolutions;

namespace CodeWarsTest.Completed;

public class FindTwinsTest
{
    [Test]
    public void SampleTests()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(FindTwins.Elimination(new int[] { 2, 5, 34, 1, 22, 1 }), Is.EqualTo(1));
            Assert.That(FindTwins.Elimination(new int[] { 2, 2, 34, 1, 22 }), Is.EqualTo(2));
            Assert.That(FindTwins.Elimination(new int[] { 2, 5, 34, 1, 22 }), Is.Null);
        }
    }
}
