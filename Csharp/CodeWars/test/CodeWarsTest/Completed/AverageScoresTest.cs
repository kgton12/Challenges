using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class AverageScoresTest
{
    [Test]
    public void BasicTests()
    {
        var scores = new int[] { 49, 3, 5, 300, 7 };
        Assert.That(AverageScores.Average(scores), Is.EqualTo(73));

        scores = [90, 98, 89, 100, 100, 86, 94];
        Assert.That(AverageScores.Average(scores), Is.EqualTo(94));
    }
}
