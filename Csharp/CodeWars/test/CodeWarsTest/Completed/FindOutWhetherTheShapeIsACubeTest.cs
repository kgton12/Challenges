using CodeWars.Resolutions;

namespace CodeWarsTest.Completed;

public class FindOutWhetherTheShapeIsACubeTest
{
    [Test, Order(1)]
    public void ShouldReturnFalse()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(FindOutWhetherTheShapeIsACube.IsCube(1, 1), Is.True);
            Assert.That(FindOutWhetherTheShapeIsACube.IsCube(8, 2), Is.True);
        }
    }

    [Test, Order(2)]
    public void ShouldReturnTrue()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(FindOutWhetherTheShapeIsACube.IsCube(2, 1), Is.False);
            Assert.That(FindOutWhetherTheShapeIsACube.IsCube(6, 3), Is.False);
            Assert.That(FindOutWhetherTheShapeIsACube.IsCube(-8, -2), Is.False);
            Assert.That(FindOutWhetherTheShapeIsACube.IsCube(0, 0), Is.False);
            Assert.That(FindOutWhetherTheShapeIsACube.IsCube(200, 4), Is.False);
        }
    }
}
