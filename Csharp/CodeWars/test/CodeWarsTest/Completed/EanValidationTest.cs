using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class EanValidationTest
{

    [Test]
    public void Test1()
    {
        Assert.That(EanValidation.Validate("9783815820865"), Is.True);
    }

    [Test]
    public void Test2()
    {
        Assert.That(EanValidation.Validate("9783815820864"), Is.False);
    }

    [Test]
    public void Test3()
    {
        Assert.That(EanValidation.Validate("9783827317100"), Is.True);
    }
}
