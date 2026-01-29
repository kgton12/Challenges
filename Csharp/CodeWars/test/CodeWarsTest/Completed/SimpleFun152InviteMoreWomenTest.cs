using CodeWars.Resolutions;

namespace CodeWarsTest.Completed;

public class SimpleFun152InviteMoreWomenTest
{
    [Test]
    public void BasicTests()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(SimpleFun152InviteMoreWomen.InviteMoreWomen([1, -1, 1]), Is.True);
            Assert.That(SimpleFun152InviteMoreWomen.InviteMoreWomen([1, 1, 1]), Is.True);
            Assert.That(SimpleFun152InviteMoreWomen.InviteMoreWomen([-1, -1, -1]), Is.False);
            Assert.That(SimpleFun152InviteMoreWomen.InviteMoreWomen([1, -1]), Is.False);
        }
    }
}
