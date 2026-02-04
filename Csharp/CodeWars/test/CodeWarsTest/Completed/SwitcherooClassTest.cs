using CodeWars.Resolutions;

namespace CodeWarsTest.Completed;

public class SwitcherooClassTest
{
    [Test]
    public void BasicTests()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(SwitcherooClass.Switcheroo("abc"), Is.EqualTo("bac"));
            Assert.That(SwitcherooClass.Switcheroo("aaabcccbaaa"), Is.EqualTo("bbbacccabbb"));
            Assert.That(SwitcherooClass.Switcheroo("ccccc"), Is.EqualTo("ccccc"));
        }
    }
}
