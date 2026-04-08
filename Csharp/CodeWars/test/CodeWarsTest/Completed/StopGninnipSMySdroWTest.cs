using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class StopGninnipsMySdrowTest
{
    [Test, Order(1)]
    public static void Test1()
    {
        var expected = "emocleW";
        Assert.That(StopGninnipSMySdroW.SpinWords("Welcome"), Is.EqualTo(expected));
    }

    [Test, Order(2)]
    public static void Test2()
    {
        var expected = "Hey wollef sroirraw";
        Assert.That(StopGninnipSMySdroW.SpinWords("Hey fellow warriors"), Is.EqualTo(expected));
    }

    [Test, Order(3)]
    public static void Test3()
    {
        var expected = "This is a test";
        Assert.That(StopGninnipSMySdroW.SpinWords("This is a test"), Is.EqualTo(expected));
    }

    [Test, Order(4)]
    public static void Test4()
    {
        var expected = "This is rehtona test";
        Assert.That(StopGninnipSMySdroW.SpinWords("This is another test"), Is.EqualTo(expected));
    }

    [Test, Order(5)]
    public static void Test5()
    {
        var expected = "You are tsomla to the last test";
        Assert.That(StopGninnipSMySdroW.SpinWords("You are almost to the last test"), Is.EqualTo(expected));
    }

    [Test, Order(6)]
    public static void Test6()
    {
        var expected = "Just gniddik ereht is llits one more";
        Assert.That(StopGninnipSMySdroW.SpinWords("Just kidding there is still one more"), Is.EqualTo(expected));
    }
}
