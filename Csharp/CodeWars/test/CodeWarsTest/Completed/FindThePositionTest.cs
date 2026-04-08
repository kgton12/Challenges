using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class FindThePositionTest
{
    [Test]
    public void BasicTests()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(FindThePosition.Position('a'), Is.EqualTo("Position of alphabet: 1"));
            Assert.That(FindThePosition.Position('z'), Is.EqualTo("Position of alphabet: 26"));
            Assert.That(FindThePosition.Position('e'), Is.EqualTo("Position of alphabet: 5"));
        }
    }
}
