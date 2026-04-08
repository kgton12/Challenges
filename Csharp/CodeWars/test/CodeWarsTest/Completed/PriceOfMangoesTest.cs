using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class PriceOfMangoesTest
{
    [Test]
    public void BasicTests()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(PriceOfMangoes.Mango(3, 3), Is.EqualTo(6));
            Assert.That(PriceOfMangoes.Mango(9, 5), Is.EqualTo(30));
        }
    }
}
