using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class CatAndMouseEasyVersionTest
{
    [Test]
    public void ExampleTests()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(CatAndMouseEasyVersion.CatMouse("C....m"), Is.EqualTo("Escaped!"));
            Assert.That(CatAndMouseEasyVersion.CatMouse("C..m"), Is.EqualTo("Caught!"));
            Assert.That(CatAndMouseEasyVersion.CatMouse("C.....m"), Is.EqualTo("Escaped!"));
        }
    }
}
