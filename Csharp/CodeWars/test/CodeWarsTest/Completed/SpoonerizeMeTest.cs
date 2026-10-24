using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class SpoonerizeMeTest
{
    [Test]
    public void NitPickingTest()
    {
        Assert.That(SpoonerizeMe.Spoonerize("nit picking"), Is.EqualTo("pit nicking"));
    }
    [Test]
    public void WeddingBellsTest()
    {
        Assert.That(SpoonerizeMe.Spoonerize("wedding bells"), Is.EqualTo("bedding wells"));
    }
    [Test]
    public void JellyBeansTest()
    {
        Assert.That(SpoonerizeMe.Spoonerize("jelly beans"), Is.EqualTo("belly jeans"));
    }
    [Test]
    public void PopCornTest()
    {
        Assert.That(SpoonerizeMe.Spoonerize("pop corn"), Is.EqualTo("cop porn"));
    }
}
