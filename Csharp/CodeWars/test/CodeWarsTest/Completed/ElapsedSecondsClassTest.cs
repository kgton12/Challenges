using CodeWars.Resolutions;

namespace CodeWarsTest.Completed;

public class ElapsedSecondsClassTest
{
    [Test]
    public void BasicTests()
    {
        var start = new DateTime(2013, 1, 1, 0, 0, 1);
        var end = new DateTime(2013, 1, 1, 0, 0, 2);
        var end2 = new DateTime(2013, 1, 1, 0, 0, 20);
        var end3 = new DateTime(2013, 1, 1, 0, 1, 20);
        using (Assert.EnterMultipleScope())
        {
            Assert.That(ElapsedSecondsClass.ElapsedSeconds(start, end), Is.EqualTo(1));
            Assert.That(ElapsedSecondsClass.ElapsedSeconds(start, end2), Is.EqualTo(19));
            Assert.That(ElapsedSecondsClass.ElapsedSeconds(start, end3), Is.EqualTo(79));
        }
    }
}