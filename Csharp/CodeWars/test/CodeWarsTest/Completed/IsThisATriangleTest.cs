using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class IsThisATriangleTest
{
    [Test]
    public void IsTriangle_ValidPostiveNumbers_ReturnsTrue()
    {
        Assert.That(IsThisATriangle.IsTriangle(5, 7, 10), Is.True);
    }
}
