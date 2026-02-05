using CodeWars.Resolutions;

namespace CodeWarsTest.Completed;

public class FindTheCombinationTest
{
    [Test]
    public void BasicTest()
    {
        Assert.That(FindTheCombination.CountCombinations("hellohellohello", "hello"), Is.EqualTo(3), "Try again! These words don't need spaces in between.");
    }
}
