using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class BuildingBlocksTest
{
    [Test]
    public static void ExampleTest()
    {
        BuildingBlocks b = new([2, 2, 2]);

        using (Assert.EnterMultipleScope())
        {
            Assert.That(b.GetWidth(), Is.EqualTo(2));
            Assert.That(b.GetLength(), Is.EqualTo(2));
            Assert.That(b.GetHeight(), Is.EqualTo(2));
            Assert.That(b.GetVolume(), Is.EqualTo(8));
            Assert.That(b.GetSurfaceArea(), Is.EqualTo(24));
        }
    }
}
