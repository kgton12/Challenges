using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class CompleteThePattern2Test
{
    [Test]
    public void SimpleNumbers()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(CompleteThePattern2.Pattern(1), Is.EqualTo("1"));
            Assert.That(CompleteThePattern2.Pattern(2), Is.EqualTo("21\n2"));
            Assert.That(CompleteThePattern2.Pattern(5), Is.EqualTo("54321\n5432\n543\n54\n5"));
            Assert.That(CompleteThePattern2.Pattern(0), Is.EqualTo(string.Empty));
            Assert.That(CompleteThePattern2.Pattern(-6), Is.EqualTo(string.Empty));
        }
    }
}