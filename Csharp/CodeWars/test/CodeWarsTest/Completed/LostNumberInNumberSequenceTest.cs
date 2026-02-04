using CodeWars.Resolutions;

namespace CodeWarsTest.Completed;

public class LostNumberInNumberSequenceTest
{
    [Test, Order(1)]
    public void MissingNumberTest()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(LostNumberInNumberSequence.FindDeletedNumber([1, 2, 3, 4, 5, 6, 7, 8, 9], [5, 7, 1, 9, 4, 8, 2, 3]), Is.EqualTo(6));
            Assert.That(LostNumberInNumberSequence.FindDeletedNumber([1], []), Is.EqualTo(1));
        }
    }

    [Test, Order(2)]
    public void NoMissingNumberTest()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(LostNumberInNumberSequence.FindDeletedNumber([1, 2, 3, 4, 5, 6, 7], [2, 3, 6, 1, 5, 4, 7]), Is.Zero);
            Assert.That(LostNumberInNumberSequence.FindDeletedNumber([1, 2, 3, 4, 5, 6, 7, 8, 9], [5, 7, 6, 9, 4, 8, 1, 2, 3]), Is.Zero);
        }
    }

    [Test, Order(3)]
    public void NilTest()
    {
        Assert.That(LostNumberInNumberSequence.FindDeletedNumber([], []), Is.Zero);
    }
}
