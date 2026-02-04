using CodeWars.Resolutions;

namespace CodeWarsTest.Completed;

public class NoOdditiesHereTest
{
    [Test]
    public void OneThroughFive()
    {
        Assert.That(NoOdditiesHere.NoOdds([1, 2, 3, 4, 5]), Is.EqualTo([2, 4]));
    }
}
