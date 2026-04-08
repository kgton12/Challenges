using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class SpoonerizeMeTest
{
    [Test, Order(1)]
    public void NitPickingTest()
    {
        Assert.That(SpoonerizeMe.Spoonerize("nit picking"), Is.EqualTo("pit nicking"));
    }
    [Test, Order(2)]
    public void WeddingBellsTest()
    {
        Assert.That(SpoonerizeMe.Spoonerize("wedding bells"), Is.EqualTo("bedding wells"));
    }
    [Test, Order(3)]
    public void JellyBeansTest()
    {
        Assert.That(SpoonerizeMe.Spoonerize("jelly beans"), Is.EqualTo("belly jeans"));
    }
    [Test, Order(4)]
    public void PopCornTest()
    {
        Assert.That(SpoonerizeMe.Spoonerize("pop corn"), Is.EqualTo("cop porn"));
    }
}
