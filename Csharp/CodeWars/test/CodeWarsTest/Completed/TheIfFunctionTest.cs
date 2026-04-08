using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class TheIfFunctionTest
{
    [Test]
    public void BasicTest()
    {
        var a = false;

        TheIfFunction.If(true, () => a = true, () => a = false);

        Assert.That(a, Is.True, "func1 should be called");
    }
}
