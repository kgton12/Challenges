using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class NextPalindromicNumberTest
{
    [Test]
    public void BasicTests()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(NextPalindromicNumber.NextPal(11), Is.EqualTo(22));
            Assert.That(NextPalindromicNumber.NextPal(188), Is.EqualTo(191));
            Assert.That(NextPalindromicNumber.NextPal(191), Is.EqualTo(202));
            Assert.That(NextPalindromicNumber.NextPal(2541), Is.EqualTo(2552));
        }
    }
}
