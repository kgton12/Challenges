using CodeWars.Resolutions;

namespace CodeWarsTest.Completed;

public class PossibilitiesArrayTest
{
    [Test, Description("Sample Tests")]
    public void SampleTest()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(PossibilitiesArray.IsAllPossibilities([0, 1, 2, 3]), Is.True);
            Assert.That(PossibilitiesArray.IsAllPossibilities([1, 2, 3, 4]), Is.False);
        }
    }
}
