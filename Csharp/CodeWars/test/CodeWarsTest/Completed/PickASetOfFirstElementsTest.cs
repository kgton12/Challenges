using CodeWars.Resolutions;

namespace CodeWarsTest.Completed;

public class PickASetOfFirstElementsTest
{
    [Test]
    public void BasicTests()
    {
        var arr = new object[] { 'a', 'b', 'c', 'd', 'e' };
        Assert.That(PickASetOfFirstElements.TakeFirstElements(arr), Is.EqualTo(new object[] { 'a' }));
        Assert.That(PickASetOfFirstElements.TakeFirstElements(arr, 2), Is.EqualTo(new object[] { 'a', 'b' }));
    }
}
