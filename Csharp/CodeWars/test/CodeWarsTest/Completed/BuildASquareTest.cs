using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class BuildASquareTest
{
    [Test]
    public void SampleTest()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(BuildASquare.GenerateShape(0), Is.EqualTo(""));
            Assert.That(BuildASquare.GenerateShape(1), Is.EqualTo("+"));
            Assert.That(BuildASquare.GenerateShape(2), Is.EqualTo("++\r\n++"));
            Assert.That(BuildASquare.GenerateShape(3), Is.EqualTo("+++\r\n+++\r\n+++"));
        }
    }
}
