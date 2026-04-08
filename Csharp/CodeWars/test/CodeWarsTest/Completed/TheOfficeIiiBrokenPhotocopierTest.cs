using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class TheOfficeIiiBrokenPhotocopierTest
{
    [Test]
    public void BasicTests()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(TheOfficeIIIBrokenPhotocopier.Broken("1"), Is.EqualTo("0"));
            Assert.That(TheOfficeIIIBrokenPhotocopier.Broken("10000000101101111110011001000"), Is.EqualTo("01111111010010000001100110111"));
            Assert.That(TheOfficeIIIBrokenPhotocopier.Broken("100010"), Is.EqualTo("011101"));
        }
    }
}
