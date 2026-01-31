using CodeWars.Resolutions;

namespace CodeWarsTest.Completed;

public class ArrayElementParityTest
{
    [Test]
    public void SampleTest()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(ArrayElementParity.Solve([1, -1, 2, -2, 3]), Is.EqualTo(3));
            Assert.That(ArrayElementParity.Solve([-3, 1, 2, 3, -1, -4, -2]), Is.EqualTo(-4));
            Assert.That(ArrayElementParity.Solve([1, -1, 2, -2, 3, 3]), Is.EqualTo(3));
            Assert.That(ArrayElementParity.Solve([-110, 110, -38, -38, -62, 62, -38, -38, -38]), Is.EqualTo(-38));
            Assert.That(ArrayElementParity.Solve([-9, -105, -9, -9, -9, -9, 105]), Is.EqualTo(-9));
        }
    }
}
