using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class PiratesAreTheCannonsReadyTest
{
    [Test, Description("should fire the cannons when ready")]
    [Order(1)]
    public void SampleAyeTest()
    {
        Dictionary<string, string> gunners = new Dictionary<string, string>
      {
        {"Mike", "aye"},
        {"Joe", "aye"},
        {"Johnson", "aye"},
        {"Peter", "aye"}
      };

        Assert.That(PiratesAreTheCannonsReady.CannonsReady(gunners), Is.EqualTo("Fire!"));
    }

    [Test, Description("should shiver me timbers if not ready")]
    [Order(2)]
    public void SampleNayTest()
    {
        Dictionary<string, string> gunners = new Dictionary<string, string>
      {
        {"Mike", "aye"},
        {"Joe", "nay"},
        {"Johnson", "aye"},
        {"Peter", "aye"}
      };

        Assert.That(PiratesAreTheCannonsReady.CannonsReady(gunners), Is.EqualTo("Shiver me timbers!"));
    }
}
