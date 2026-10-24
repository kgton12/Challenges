using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class GrasshopperBugSquashingTest
{
    [Test, Description("GrasshopperBugSquashing should define variables and store values")]
    public void VariableTest()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(GrasshopperBugSquashing.Health, Is.EqualTo(100));
            Assert.That(GrasshopperBugSquashing.Position, Is.Zero);
            Assert.That(GrasshopperBugSquashing.Coins, Is.Zero);
        }
    }

    [Test, Description("PlayTurn should not throw an exception")]
    public void ErrorTest()
    {
        Assert.That(() => GrasshopperBugSquashing.PlayTurn(), Throws.Nothing);
    }

    [Test, Description("should roll dice first")]
    public void OrderTest1()
    {
        Assert.That(GrasshopperBugSquashing.Log[0], Is.EqualTo("RollDice"));
    }

    [Test, Description("should move second")]
    public void OrderTest2()
    {
        Assert.That(GrasshopperBugSquashing.Log[1], Is.EqualTo("Move"));
    }

    [Test, Description("should combat third")]
    public void OrderTest3()
    {
        Assert.That(GrasshopperBugSquashing.Log[2], Is.EqualTo("Combat"));
    }

    [Test, Description("should get coins fourth")]
    public void OrderTest4()
    {
        Assert.That(GrasshopperBugSquashing.Log[3], Is.EqualTo("GetCoins"));
    }

    [Test, Description("should buy health fifth")]
    public void OrderTest5()
    {
        Assert.That(GrasshopperBugSquashing.Log[4], Is.EqualTo("BuyHealth"));
    }

    [Test, Description("should print status sixth")]
    public void OrderTest6()
    {
        Assert.That(GrasshopperBugSquashing.Log[5], Is.EqualTo("PrintStatus"));
    }
}
