using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class GrasshopperBugSquashingTest
{
    [Test, Description("GrasshopperBugSquashing should define variables and store values"), Order(1)]
    public void VariableTest()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(GrasshopperBugSquashing.Health, Is.EqualTo(100));
            Assert.That(GrasshopperBugSquashing.Position, Is.Zero);
            Assert.That(GrasshopperBugSquashing.Coins, Is.Zero);
        }
    }

    [Test, Description("PlayTurn should not throw an exception"), Order(2)]
    public void ErrorTest()
    {
        Assert.That(() => GrasshopperBugSquashing.PlayTurn(), Throws.Nothing);
    }

    [Test, Description("should roll dice first"), Order(3)]
    public void OrderTest1()
    {
        Assert.That(GrasshopperBugSquashing.Log[0], Is.EqualTo("RollDice"));
    }

    [Test, Description("should move second"), Order(4)]
    public void OrderTest2()
    {
        Assert.That(GrasshopperBugSquashing.Log[1], Is.EqualTo("Move"));
    }

    [Test, Description("should combat third"), Order(5)]
    public void OrderTest3()
    {
        Assert.That(GrasshopperBugSquashing.Log[2], Is.EqualTo("Combat"));
    }

    [Test, Description("should get coins fourth"), Order(6)]
    public void OrderTest4()
    {
        Assert.That(GrasshopperBugSquashing.Log[3], Is.EqualTo("GetCoins"));
    }

    [Test, Description("should buy health fifth"), Order(7)]
    public void OrderTest5()
    {
        Assert.That(GrasshopperBugSquashing.Log[4], Is.EqualTo("BuyHealth"));
    }

    [Test, Description("should print status sixth"), Order(8)]
    public void OrderTest6()
    {
        Assert.That(GrasshopperBugSquashing.Log[5], Is.EqualTo("PrintStatus"));
    }
}
