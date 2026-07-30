using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class SequencesAndSeriesTest
{
    [Test]
    public void BasicTests()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(SequencesAndSeries.GetScore(1), Is.EqualTo(50), "GetScore(1) returns a wrong result");
            Assert.That(SequencesAndSeries.GetScore(2), Is.EqualTo(150), "GetScore(2) returns a wrong result");
            Assert.That(SequencesAndSeries.GetScore(3), Is.EqualTo(300), "GetScore(3) returns a wrong result");
            Assert.That(SequencesAndSeries.GetScore(4), Is.EqualTo(500), "GetScore(4) returns a wrong result");
            Assert.That(SequencesAndSeries.GetScore(5), Is.EqualTo(750), "GetScore(5) returns a wrong result");
        }
    }
}
