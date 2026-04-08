using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class ConvertBooleanValuesToStringsYesOrNoTest
{
    [Test]
    public void BoolToWordReturned1()
    {
        Assert.That(ConvertBooleanValuesToStringsYesOrNo.BoolToWord(true), Is.EqualTo("Yes"), "Incorrect answer for word=\"true\"");
    }

    [Test]
    public void BoolToWordReturned2()
    {
        Assert.That(ConvertBooleanValuesToStringsYesOrNo.BoolToWord(false), Is.EqualTo("No"), "Incorrect answer for word=\"false\"");
    }

    [Test]
    public void BoolToWordReturned3()
    {
        Assert.That(ConvertBooleanValuesToStringsYesOrNo.BoolToWord(true), Is.EqualTo("Yes"), "Incorrect answer for word=\"true\"");
    }
}
