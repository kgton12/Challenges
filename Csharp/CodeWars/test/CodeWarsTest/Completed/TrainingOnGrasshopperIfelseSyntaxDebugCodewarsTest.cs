using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class TrainingOnGrasshopperIfelseSyntaxDebugCodewarsTest
{
    [Test, Description("Should return the proper result with fixed tests")]
    public void FixedTest()
    {
        var greg = new TrainingOnGrasshopperIfelseSyntaxDebugCodewars
        {
            Health = 5
        };
        Assert.That(greg.CheckAlive(), Is.True);

        var joe = new TrainingOnGrasshopperIfelseSyntaxDebugCodewars
        {
            Health = 0
        };
        Assert.That(joe.CheckAlive(), Is.False);
    }
}