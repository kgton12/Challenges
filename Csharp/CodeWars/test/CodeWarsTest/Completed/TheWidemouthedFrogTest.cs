using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class TheWidemouthedFrogTest
{
    [Test]
    public void SampleTest()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(TheWidemouthedFrog.MouthSize("toucan"), Is.EqualTo("wide"));
            Assert.That(TheWidemouthedFrog.MouthSize("ant bear"), Is.EqualTo("wide"));
            Assert.That(TheWidemouthedFrog.MouthSize("alligator"), Is.EqualTo("small"));
        }
    }
}