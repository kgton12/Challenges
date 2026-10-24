using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class ValidBracesClassTest
{
    [Test]
    public void Test1()
    {
        Assert.That(ValidBracesClass.ValidBraces("(){}[]"), Is.True);
    }

    [Test]
    public void Test2()
    {
        Assert.That(ValidBracesClass.ValidBraces("([{}])"), Is.True);
    }
    [Test]
    public void Test3()
    {
        Assert.That(ValidBracesClass.ValidBraces("(}"), Is.False);
    }
    [Test]
    public void Test4()
    {
        Assert.That(ValidBracesClass.ValidBraces("[(])"), Is.False);
    }
    [Test]
    public void Test5()
    {
        Assert.That(ValidBracesClass.ValidBraces("[({})](]"), Is.False);
    }
}