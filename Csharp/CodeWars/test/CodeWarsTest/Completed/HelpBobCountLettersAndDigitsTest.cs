using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class HelpBobCountLettersAndDigitsTest
{
    [Test]
    public void Test1()
    {
        Assert.That(HelpBobCountLettersAndDigits.CountLettersAndDigits("n!!ice!!123"), Is.EqualTo(7));
    }
}
