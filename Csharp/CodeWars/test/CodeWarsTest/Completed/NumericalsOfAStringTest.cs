using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class NumericalsOfAStringTest
{
    [Test, Order(1)]
    public void BasicTest1()
    {
        Assert.That(NumericalsOfAString.Numericals("Hello, World!"), Is.EqualTo("1112111121311"));
    }

    [Test, Order(2)]
    public void BasicTest2()
    {
        Assert.That(NumericalsOfAString.Numericals("Hello, World! It's me, JomoPipi!"), Is.EqualTo("11121111213112111131224132411122"));
    }

    [Test, Order(3)]
    public void BasicTest3()
    {
        Assert.That(NumericalsOfAString.Numericals("hello hello"), Is.EqualTo("11121122342"));
    }
}
