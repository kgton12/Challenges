using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class ReversedSequenceTest
{
    [Test]
    public void SampleTest()
    {
        Assert.That(ReversedSequence.ReverseSeq(5), Is.EqualTo([5, 4, 3, 2, 1]));
    }
}
