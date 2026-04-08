using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class SwitchItUpTest
{
    [Test]
    public void BasicTests()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(SwitchItUpClass.SwitchItUp(1), Is.EqualTo("One"));
            Assert.That(SwitchItUpClass.SwitchItUp(3), Is.EqualTo("Three"));
            Assert.That(SwitchItUpClass.SwitchItUp(5), Is.EqualTo("Five"));
        }
    }
}