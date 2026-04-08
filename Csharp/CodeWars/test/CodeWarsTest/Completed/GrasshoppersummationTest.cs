using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class GrasshoppersummationTest
{
    [Test, Order(1)]
    public static void BasicTests()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(GrasshopperSummation.Summation(1), Is.EqualTo(1));
            Assert.That(GrasshopperSummation.Summation(8), Is.EqualTo(36));
            Assert.That(GrasshopperSummation.Summation(22), Is.EqualTo(253));
            Assert.That(GrasshopperSummation.Summation(100), Is.EqualTo(5050));
            Assert.That(GrasshopperSummation.Summation(213), Is.EqualTo(22791));
        }
    }
}
