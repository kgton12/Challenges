using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class MessageValidatorTest
{
    [Test]
    public void Test1()
    {
        Assert.That(MessageValidator.IsAValidMessage("3hey5hello2hi"), Is.True);
    }

    [Test]
    public void Test2()
    {
        Assert.That(MessageValidator.IsAValidMessage("4code13hellocodewars"), Is.True);
    }

    [Test]
    public void Test3()
    {
        Assert.That(MessageValidator.IsAValidMessage("3hey5hello2hi5"), Is.False);
    }

    [Test]
    public void Test4()
    {
        Assert.That(MessageValidator.IsAValidMessage("code4hello5"), Is.False);
    }

    [Test]
    public void Test5()
    {
        Assert.That(MessageValidator.IsAValidMessage("1a2bb3ccc4dddd5eeeee"), Is.True);
    }

    [Test]
    public void Test6()
    {
        Assert.That(MessageValidator.IsAValidMessage(""), Is.True);
    }
}
