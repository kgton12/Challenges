using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class SimpleFun74GrowingPlantTest
{
    [Test]
    public void BasicTests()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(SimpleFun74GrowingPlant.GrowingPlant(100, 10, 910), Is.EqualTo(10));
            Assert.That(SimpleFun74GrowingPlant.GrowingPlant(10, 9, 4), Is.EqualTo(1));
        }
    }
}
