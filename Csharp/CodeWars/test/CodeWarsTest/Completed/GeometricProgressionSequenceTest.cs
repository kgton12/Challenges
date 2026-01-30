using CodeWars.Resolutions;

namespace CodeWarsTest.Completed;

public class GeometricProgressionSequenceTest
{
    [Test]
    public void FixedTests()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(GeometricProgressionSequence.GeometricSequenceElements(2, 3, 5), Is.EqualTo("2, 6, 18, 54, 162"));
            Assert.That(GeometricProgressionSequence.GeometricSequenceElements(2, 2, 10), Is.EqualTo("2, 4, 8, 16, 32, 64, 128, 256, 512, 1024"));
            Assert.That(GeometricProgressionSequence.GeometricSequenceElements(1, -2, 10), Is.EqualTo("1, -2, 4, -8, 16, -32, 64, -128, 256, -512"));
        }
    }
}
