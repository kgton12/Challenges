using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class VolumeOfACuboidTest
{
    [Test]
    public void SampleTests()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(VolumeOfACuboid.GetVolumeOfCuboid(2, 5, 6), Is.EqualTo(60).Within(0.00001), "Length: 2, Width: 5, Height: 6");
            Assert.That(VolumeOfACuboid.GetVolumeOfCuboid(6.3, 3, 5), Is.EqualTo(94.5).Within(0.00001), "Length: 6.3, Width: 3, Height: 5");
        }
    }
}
