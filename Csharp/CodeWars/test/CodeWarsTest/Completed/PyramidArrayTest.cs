using CodeWars.Resolutions;

namespace CodeWarsTest.Completed;

public class PyramidArrayTest
{
    [Test]
    public void BasicTests()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(PyramidArray.Pyramid(0), Is.EqualTo(Array.Empty<int[]>()));
            Assert.That(PyramidArray.Pyramid(1), Is.EqualTo(new int[][] { [1] }));
            Assert.That(PyramidArray.Pyramid(2), Is.EqualTo(new int[][] { [1], [1, 1] }));
            Assert.That(PyramidArray.Pyramid(3), Is.EqualTo(new int[][] { [1], [1, 1], [1, 1, 1] }));
        }
    }
}
