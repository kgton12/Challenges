using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class OffloadYourWorkTest
{
    [Test]
    public void BasicTest1()
    {
        var arr = new int[][] { [1, 0] };
        Assert.That(OffloadYourWork.WorkNeeded(60, arr), Is.EqualTo("Easy Money!"));
    }
    [Test]
    public void BasicTest2()
    {
        var arr = new int[][] { [0, 0] };
        Assert.That(OffloadYourWork.WorkNeeded(60, arr), Is.EqualTo("I need to work 1 hour(s) and 0 minute(s)"));
    }
    [Test]
    public void BasicTest3()
    {
        var arr = new int[][] { [1, 55], [0, 25] };
        Assert.That(OffloadYourWork.WorkNeeded(141, arr), Is.EqualTo("I need to work 0 hour(s) and 1 minute(s)"));
    }
}