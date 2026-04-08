using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class SillycaseTest
{
    [Test]
    public void SampleTest()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(Sillycase.SillyCase("foobar"), Is.EqualTo("fooBAR"));
            Assert.That(Sillycase.SillyCase("codewars"), Is.EqualTo("codeWARS"));
            Assert.That(Sillycase.SillyCase("brian"), Is.EqualTo("briAN"));
        }
    }
}
