using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class MessageValidatorTest
{
    [Test, Order(1)]
    public void Test1()
    {
        Assert.That(MessageValidator.IsAValidMessage("3hey5hello2hi"), Is.True);
    }

    [Test, Order(2)]
    public void Test2()
    {
        Assert.That(MessageValidator.IsAValidMessage("4code13hellocodewars"), Is.True);
    }

    [Test, Order(3)]
    public void Test3()
    {
        Assert.That(MessageValidator.IsAValidMessage("3hey5hello2hi5"), Is.False);
    }

    [Test, Order(4)]
    public void Test4()
    {
        Assert.That(MessageValidator.IsAValidMessage("code4hello5"), Is.False);
    }

    [Test, Order(5)]
    public void Test5()
    {
        Assert.That(MessageValidator.IsAValidMessage("1a2bb3ccc4dddd5eeeee"), Is.True);
    }

    [Test, Order(6)]
    public void Test6()
    {
        Assert.That(MessageValidator.IsAValidMessage(""), Is.True);
    }
}
