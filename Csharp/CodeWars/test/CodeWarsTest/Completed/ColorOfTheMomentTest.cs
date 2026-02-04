using CodeWars.Resolutions;

namespace CodeWarsTest.Completed;

public class ColorOfTheMomentTest
{
    [Test]
    public void _0_BasicTests()
    {

        Assert.That(ColorOfTheMoment.HexToTime("#0d3737"), Is.EqualTo("13:55:55"));

        Assert.That(() => ColorOfTheMoment.HexToTime("#2c3721"), Throws.Exception, "Thats not a valid time!");
    }
}
