using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class TheZeroAllocationParserReadonlyspanTest
{
    [Test]
    public static void Behavioral_ParsesCorrectly()
    {
        // Passing a string implicitly converts to ReadOnlySpan if the user updated the signature!
        double price = TheZeroAllocationParserReadonlyspan.ParseStockPrice("SYM:MSFT|PRC:310.50|VOL:5000");
        Assert.That(price, Is.EqualTo(310.50), "Failed to parse the correct price.");
    }

    [Test]
    public void Behavioral_HandlesMissingVolume()
    {
        double price = TheZeroAllocationParserReadonlyspan.ParseStockPrice("SYM:TSLA|PRC:299.99");
        Assert.That(price, Is.EqualTo(299.99), "Failed to parse when |VOL: is missing.");
    }
}