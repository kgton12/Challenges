using CodeWars.Resolutions;

namespace CodeWarsTest.Completed;

public class EanValidationTest
{

    [Test, Order(1)]
    public void Test1()
    {
        Assert.That(EanValidation.Validate("9783815820865"), Is.True);
    }

    [Test, Order(2)]
    public void Test2()
    {
        Assert.That(EanValidation.Validate("9783815820864"), Is.False);
    }

    [Test, Order(3)]
    public void Test3()
    {
        Assert.That(EanValidation.Validate("9783827317100"), Is.True);
    }
}
