using CodeWars.Resolutions;

namespace CodeWarsTest.Completed;

public class TakeAnArrowToTheKneeFunctionallyTest
{
    [Test]
    public static void FixedTests()
    {
        Assert.That(TakeAnArrowToTheKneeFunctionally.ArrowFunc(new int[] { 84, 101, 115, 116 }), Is.EqualTo("Test"));
    }
}
