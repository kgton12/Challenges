using CodeWars.Resolutions;

namespace CodeWarsTest.Completed;

public class NoOdditiesHereTest
{
    [Test]
    public void OneThroughFive()
    {
        Assert.That(NoOdditiesHere.NoOdds(new int[] { 1, 2, 3, 4, 5 }), Is.EqualTo(new int[] { 2, 4 }));
    }
}
