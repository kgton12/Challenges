using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class Speedcode2ArrayMadnessTest
{
    [Test, Description("Should work for sample tests")]
    public void SampleTest()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(Speedcode2ArrayMadness.ArrayMadness([4, 5, 6], [1, 2, 3]), Is.True);
            Assert.That(Speedcode2ArrayMadness.ArrayMadness([5, 6, 7], [4, 5, 6]), Is.False);
        }
    }
}
