using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class DistancesFromTheAverageTest
{
    [Test]
    public void ExampleTests()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(DistanceFromTheAverage.DistancesFromAverage([55, 95, 62, 36, 48]), Is.EqualTo([4.2, -35.8, -2.8, 23.2, 11.2]));
            Assert.That(DistanceFromTheAverage.DistancesFromAverage([1, 1, 1, 1, 1]), Is.EqualTo([0, 0, 0, 0, 0]));
            Assert.That(DistanceFromTheAverage.DistancesFromAverage([1, -1, 1, -1, 1, -1]), Is.EqualTo([-1.0, 1.0, -1.0, 1.0, -1.0, 1.0]));
            Assert.That(DistanceFromTheAverage.DistancesFromAverage([1, -1, 1, -1, 1]), Is.EqualTo([-0.8, 1.2, -0.8, 1.2, -0.8]));
            Assert.That(DistanceFromTheAverage.DistancesFromAverage([2, -2]), Is.EqualTo([-2.0, 2.0]));
            Assert.That(DistanceFromTheAverage.DistancesFromAverage([1]), Is.EqualTo([0]));
            Assert.That(DistanceFromTheAverage.DistancesFromAverage([123, -65, 32432, -353, -534]), Is.EqualTo([6197.6, 6385.6, -26111.4, 6673.6, 6854.6]));
        }
    }
}
