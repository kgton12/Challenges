using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class BasicCalculatorTest
{
    [Test]
    public void Test_01()
    {
        Assert.That(BasicCalculator.Execute(3.2, '+', 8), Is.EqualTo(11.2));
    }

    [Test]
    public void Test_02()
    {
        Assert.That(BasicCalculator.Execute(3.2, '-', 8), Is.EqualTo(-4.8));
    }

    [Test]
    public void Test_03()
    {
        Assert.That(BasicCalculator.Execute(3.2, '/', 8), Is.EqualTo(0.4));
    }

    [Test]
    public void Test_04()
    {
        Assert.That(BasicCalculator.Execute(3.2, '*', 8), Is.EqualTo(25.6));
    }

    [Test]
    public void Test_10()
    {
        Assert.Throws<ArgumentException>(() => BasicCalculator.Execute(-3, 'w', 1));
    }
}
