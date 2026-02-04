using CodeWars.Resolutions;

namespace CodeWarsTest.Completed;

public class RegexpBasicsIsItADigitTest
{
    [Test]
    public void BasicTests()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That("".Digit(), Is.False);
            Assert.That("7".Digit(), Is.True);
            Assert.That(" ".Digit(), Is.False);
            Assert.That("a".Digit(), Is.False);
            Assert.That("a5".Digit(), Is.False);
            Assert.That("14".Digit(), Is.False);
        }
    }
}
