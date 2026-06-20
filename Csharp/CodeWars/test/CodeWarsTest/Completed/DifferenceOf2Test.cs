using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class DifferenceOf2Test
{
    [Test]
    public void Tests()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(DifferenceOf2.TwosDifference([1, 2, 3, 4]), Is.EqualTo([(1, 3), (2, 4)]));
            Assert.That(DifferenceOf2.TwosDifference([1, 3, 4, 6]), Is.EqualTo([(1, 3), (4, 6)]));
            Assert.That(DifferenceOf2.TwosDifference([6, 4, 3, 1]), Is.EqualTo([(1, 3), (4, 6)]));
        }
    }
}