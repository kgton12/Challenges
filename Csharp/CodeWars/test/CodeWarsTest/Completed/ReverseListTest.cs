using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class ReverseListTest
{
    [Test]
    public void MyTest()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(ReverseListClass.ReverseList([]), Is.EqualTo(new int[0]));
            Assert.That(ReverseListClass.ReverseList([1, 2, 3]), Is.EqualTo([3, 2, 1]));
        }
    }
}
