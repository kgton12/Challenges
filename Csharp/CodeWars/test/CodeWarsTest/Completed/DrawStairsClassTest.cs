using CodeWars.Resolutions;

namespace CodeWarsTest.Completed;

public class DrawStairsClassTest
{
    [Test]
    public void SampleTests()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(DrawStairsClass.DrawStairs(1), Is.EqualTo("I"));
            Assert.That(DrawStairsClass.DrawStairs(2), Is.EqualTo("I\n I"));
            Assert.That(DrawStairsClass.DrawStairs(3), Is.EqualTo("I\n I\n  I"));
            Assert.That(DrawStairsClass.DrawStairs(4), Is.EqualTo("I\n I\n  I\n   I"));
        }
    }
}
