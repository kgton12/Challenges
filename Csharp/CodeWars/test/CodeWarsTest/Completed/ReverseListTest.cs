using CodeWars.Resolutions;

namespace CodeWarsTest.Completed;

public class ReverseListTest
{
    [Test]
    public void MyTest()
    {
        Assert.That(ReverseListClass.ReverseList(new int[0]), Is.EqualTo(new int[0]));
        Assert.That(ReverseListClass.ReverseList(new int[] { 1, 2, 3 }), Is.EqualTo(new int[] { 3, 2, 1 }));
    }
}
