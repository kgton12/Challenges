using CodeWars.Resolutions;

namespace CodeWarsTest.Completed;

public class GrasshopperPersonalizedMessageTest
{
    [Test]
    public void MyTest()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(GrasshopperPersonalizedMessage.Greet("Daniel", "Daniel"), Is.EqualTo("Hello boss"));
            Assert.That(GrasshopperPersonalizedMessage.Greet("Greg", "Daniel"), Is.EqualTo("Hello guest"));
        }
    }
}
