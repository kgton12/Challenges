using CodeWars.Resolutions;

namespace CodeWarsTest.Completed;

public class CompleteThePattern4Test
{
    [Test]
    public void BasicTests()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(CompleteThePattern4.Pattern(1), Is.EqualTo("1"));
            Assert.That(CompleteThePattern4.Pattern(2), Is.EqualTo("12\n2"));
            Assert.That(CompleteThePattern4.Pattern(5), Is.EqualTo("12345\n2345\n345\n45\n5"));
        }
    }
}
