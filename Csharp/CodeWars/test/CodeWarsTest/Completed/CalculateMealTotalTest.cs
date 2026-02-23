using CodeWars.Resolutions;

namespace CodeWarsTest.Completed;

public class CalculateMealTotalTest
{
    [Test]
    public void Tests()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(CalculateMealTotal.CalculateTotal(5.00, 5, 10), Is.EqualTo(5.75));
            Assert.That(CalculateMealTotal.CalculateTotal(36.97, 7, 15), Is.EqualTo(45.10));
        }
    }
}
