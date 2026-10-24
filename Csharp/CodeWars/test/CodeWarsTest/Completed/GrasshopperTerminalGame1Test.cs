using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class GrasshopperTerminalGame1Test
{
    [Test, Description("Hero should create a Hero")]
    
    public void InitTest()
    {
        GrasshopperTerminalGame1 myHero = new();
        Assert.That(myHero.Name, Is.EqualTo("Hero"));
    }

    [Test, Description("Hero should have appropriate types for its properties")]
    
    public void TypeTest()
    {
        GrasshopperTerminalGame1 myHero = new();
        Assert.That(myHero.Health, Is.TypeOf<float>());
    }
}
