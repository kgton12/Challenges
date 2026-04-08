using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class CatYearsDogYears2Test
{
    [Test, Order(1)]
    public void One()
    {
        Assert.That(CatYearsDogYears2.OwnedCatAndDog(15, 15), Is.EqualTo((1, 1)));
    }

    [Test, Order(2)]
    public void Two()
    {
        Assert.That(CatYearsDogYears2.OwnedCatAndDog(24, 24), Is.EqualTo((2, 2)));
    }

    [Test, Order(3)]
    public void Ten()
    {
        Assert.That(CatYearsDogYears2.OwnedCatAndDog(56, 64), Is.EqualTo((10, 10)));
    }
}
