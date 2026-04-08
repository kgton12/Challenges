using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class CompleteThePattern3HorizontalImageOf2Test
{
    [Test]
    public void BasicTests()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(CompleteThePattern3HorizontalImageOf2.Pattern(-3), Is.EqualTo(""));
            Assert.That(CompleteThePattern3HorizontalImageOf2.Pattern(0), Is.EqualTo(""));
            Assert.That(CompleteThePattern3HorizontalImageOf2.Pattern(1), Is.EqualTo("1"));
            Assert.That(CompleteThePattern3HorizontalImageOf2.Pattern(2), Is.EqualTo("2\n21"));
            Assert.That(CompleteThePattern3HorizontalImageOf2.Pattern(5), Is.EqualTo("5\n54\n543\n5432\n54321"));
        }
    }
}
