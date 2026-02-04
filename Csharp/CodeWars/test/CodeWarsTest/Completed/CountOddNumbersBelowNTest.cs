using CodeWars.Resolutions;

namespace CodeWarsTest.Completed;

public class CountOddNumbersBelowNTest
{
    [Test]
    public void Test()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(CountOddNumbersBelowN.OddCount(15), Is.EqualTo(7));
            Assert.That(CountOddNumbersBelowN.OddCount(15023), Is.EqualTo(7511));
        }
    }
}
