using CodeWars.Resolutions;

namespace CodeWarsTest.Completed;

public class SimpleStringReversalTest
{
    [Test]
    public void ExampleTests()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(SimpleStringReversal.Solve("codewars"), Is.EqualTo("srawedoc"));
            Assert.That(SimpleStringReversal.Solve("your code"), Is.EqualTo("edoc ruoy"));
            Assert.That(SimpleStringReversal.Solve("your code rocks"), Is.EqualTo("skco redo cruoy"));
        }

    }
}
