using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class HeHiddenWordTest
{
    [TestCase, Order(1)]
    public void BasicTest1()
    {
        Assert.That(TheHiddenWord.Hidden(637), Is.EqualTo("aid"));
    }

    [TestCase, Order(2)]
    public void BasicTest2()
    {
        Assert.That(TheHiddenWord.Hidden(7415), Is.EqualTo("debt"));
    }

    [TestCase, Order(3)]
    public void BasicTest3()
    {
        Assert.That(TheHiddenWord.Hidden(49632), Is.EqualTo("email"));
    }

    [TestCase, Order(4)]
    public void BasicTest4()
    {
        Assert.That(TheHiddenWord.Hidden(942547), Is.EqualTo("melted"));
    }
}
