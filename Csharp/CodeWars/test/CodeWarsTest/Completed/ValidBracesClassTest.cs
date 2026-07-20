using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class ValidBracesClassTest
{
    [Test, Order(1)]
    public void Test1()
    {
        Assert.That(ValidBracesClass.ValidBraces("(){}[]"), Is.True);
    }

    [Test, Order(2)]
    public void Test2()
    {
        Assert.That(ValidBracesClass.ValidBraces("([{}])"), Is.True);
    }
    [Test, Order(3)]
    public void Test3()
    {
        Assert.That(ValidBracesClass.ValidBraces("(}"), Is.False);
    }
    [Test, Order(4)]
    public void Test4()
    {
        Assert.That(ValidBracesClass.ValidBraces("[(])"), Is.False);
    }
    [Test, Order(5)]
    public void Test5()
    {
        Assert.That(ValidBracesClass.ValidBraces("[({})](]"), Is.False);
    }
}