using CodeWars.Resolutions;

namespace CodeWarsTest.Completed;

public class MakeuppercaseTest
{
    [Test]
    public void BasicTest()
    {
        Assert.That(MakeUpperCaseClass.MakeUpperCase("hello"), Is.EqualTo("HELLO"));
    }
}
