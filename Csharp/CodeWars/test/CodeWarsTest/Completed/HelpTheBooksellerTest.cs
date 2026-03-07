using CodeWars.Resolutions;

namespace CodeWarsTest.Completed;

public class HelpTheBooksellerTest
{
    [Test]
    public void Test1()
    {
        string[] art = ["ABAR 200", "CDXE 500", "BKWR 250", "BTSQ 890", "DRTY 600"];
        string[] cd = ["A", "B"];
        Assert.That(HelpTheBookseller.StockSummary(art, cd), Is.EqualTo("(A : 200) - (B : 1140)"));
    }
}
