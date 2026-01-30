using CodeWars.Resolutions;

namespace CodeWarsTest.Completed;

public class IfYouCantSleepJustCountSheepTest
{
    [Test, Description("Example Tests")]
    public void ExampleTests()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(IfYouCantSleepJustCountSheep.CountSheep(0), Is.EqualTo(""));
            Assert.That(IfYouCantSleepJustCountSheep.CountSheep(1), Is.EqualTo("1 sheep..."));
            Assert.That(IfYouCantSleepJustCountSheep.CountSheep(2), Is.EqualTo("1 sheep...2 sheep..."));
            Assert.That(IfYouCantSleepJustCountSheep.CountSheep(3), Is.EqualTo("1 sheep...2 sheep...3 sheep..."));
        }
    }
}
