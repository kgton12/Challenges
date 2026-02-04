using CodeWars.Resolutions;

namespace CodeWarsTest.Completed;

public class YouGotChangeTest
{
    [Test]
    public void BasicTest()
    {
        Assert.That(YouGotChange.GiveChange(365), Is.EqualTo(new int[] { 0, 1, 1, 0, 1, 3 }));
        Assert.That(YouGotChange.GiveChange(217), Is.EqualTo(new int[] { 2, 1, 1, 0, 0, 2 }));
    }
}
