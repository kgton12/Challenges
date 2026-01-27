using CodeWars.Resolutions;

namespace CodeWarsTest.Completed;

public class DuplicateEncoderTest
{
    [Test]
    public void BasicTests()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(DuplicateEncoder.DuplicateEncode("din"), Is.EqualTo("((("));
            Assert.That(DuplicateEncoder.DuplicateEncode("recede"), Is.EqualTo("()()()"));
            Assert.That(DuplicateEncoder.DuplicateEncode("Success"), Is.EqualTo(")())())"), "should ignore case");
            Assert.That(DuplicateEncoder.DuplicateEncode("(( @"), Is.EqualTo("))(("));
        }
    }
}
