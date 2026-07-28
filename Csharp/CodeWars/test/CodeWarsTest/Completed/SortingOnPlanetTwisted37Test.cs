using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class SortingOnPlanetTwisted37Test
{
    [Test]
    public void BasicTests()
    {
        var expected1 = string.Join(",", [1, 2, 7, 4, 5, 6, 3, 8, 9]);
        Assert.That(string.Join(",", SortingOnPlanetTwisted37.SortTwisted37([1, 2, 3, 4, 5, 6, 7, 8, 9])), Is.EqualTo(expected1));

        var expected2 = string.Join(",", [12, 14, 13]);
        Assert.That(string.Join(",", SortingOnPlanetTwisted37.SortTwisted37([12, 13, 14])), Is.EqualTo(expected2));

        var expected3 = string.Join(",", [2, 7, 4, 3, 9]);
        Assert.That(string.Join(",", SortingOnPlanetTwisted37.SortTwisted37([9, 2, 4, 7, 3])), Is.EqualTo(expected3));
    }
}
