using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class YouGotChangeTest
{
    [Test]
    public void BasicTest()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(YouGotChange.GiveChange(365), Is.EqualTo([0, 1, 1, 0, 1, 3]));
            Assert.That(YouGotChange.GiveChange(217), Is.EqualTo([2, 1, 1, 0, 0, 2]));
        }
    }
}
