using CodeWars.Resolutions;

namespace CodeWarsTest.Completed;

public class ResponsibleDrinkingTest
{

    [Test, Order(1)]
    public void DrinkinTest1()
    {
        string expected = "1 glass of water";
        string actual = ResponsibleDrinking.Hydrate("1 beer");
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test, Order(2)]
    public void DrinkinTest3()
    {
        string expected = "10 glasses of water";
        string actual = ResponsibleDrinking.Hydrate("1 shot, 5 beers, 2 shots, 1 glass of wine, 1 beer");
        Assert.That(actual, Is.EqualTo(expected));
    }
}
