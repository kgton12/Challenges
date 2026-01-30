using CodeWars.Resolutions;

namespace CodeWarsTest.Completed;

public class SurfaceAreaAndVolumeOfABoxTest
{
    [Test]
    public void Test1()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(SurfaceAreaAndVolumeOfABox.GetSize(4, 2, 6), Is.EqualTo([88, 48]));
            Assert.That(SurfaceAreaAndVolumeOfABox.GetSize(1, 1, 1), Is.EqualTo([6, 1]));
            Assert.That(SurfaceAreaAndVolumeOfABox.GetSize(1, 2, 1), Is.EqualTo([10, 2]));
            Assert.That(SurfaceAreaAndVolumeOfABox.GetSize(1, 2, 2), Is.EqualTo([16, 4]));
            Assert.That(SurfaceAreaAndVolumeOfABox.GetSize(10, 10, 10), Is.EqualTo([600, 1000]));
        }
    }
}
