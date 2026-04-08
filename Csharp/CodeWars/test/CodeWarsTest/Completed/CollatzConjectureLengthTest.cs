using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class CollatzConjectureLengthTest
{
    [Test]
    public void SampleTest()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(CollatzConjectureLength.Collatz(20), Is.EqualTo(8));
            Assert.That(CollatzConjectureLength.Collatz(15), Is.EqualTo(18));
        }
    }
}
