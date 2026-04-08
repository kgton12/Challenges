using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class Function2SquaringAnArgumentTest
{
    [Test, Description("Sample Tests")]
    public void Test()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(Function2SquaringAnArgument.Square(2), Is.EqualTo(4));
            Assert.That(Function2SquaringAnArgument.Square(10), Is.EqualTo(100));
        }
    }
}
