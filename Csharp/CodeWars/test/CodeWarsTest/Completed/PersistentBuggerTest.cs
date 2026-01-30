using CodeWars.Resolutions;

namespace CodeWarsTest.Completed;

public class PersistentBuggerTest
{
    [Test]
    public void ExampleTests()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(PersistentBugger.Persistence(39), Is.EqualTo(3));
            Assert.That(PersistentBugger.Persistence(4), Is.Zero);
            Assert.That(PersistentBugger.Persistence(25), Is.EqualTo(2));
            Assert.That(PersistentBugger.Persistence(999), Is.EqualTo(4));
        }
    }
}
