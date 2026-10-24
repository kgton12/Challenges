using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class NumericalsOfAStringTest
{
    [Test]
    public void BasicTest1()
    {
        Assert.That(NumericalsOfAString.Numericals("Hello, World!"), Is.EqualTo("1112111121311"));
    }

    [Test]
    public void BasicTest2()
    {
        Assert.That(NumericalsOfAString.Numericals("Hello, World! It's me, JomoPipi!"), Is.EqualTo("11121111213112111131224132411122"));
    }

    [Test]
    public void BasicTest3()
    {
        Assert.That(NumericalsOfAString.Numericals("hello hello"), Is.EqualTo("11121122342"));
    }
}
