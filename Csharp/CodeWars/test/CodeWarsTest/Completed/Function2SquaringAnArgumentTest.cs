using CodeWars.Resolutions;

namespace CodeWarsTest.Completed;

public class Function2SquaringAnArgumentTest
{
    [Test, Description("Sample Tests")]
    public void Test()
    {
        Assert.That(Function2SquaringAnArgument.Square(2), Is.EqualTo(4));
        Assert.That(Function2SquaringAnArgument.Square(10), Is.EqualTo(100));
    }
}
