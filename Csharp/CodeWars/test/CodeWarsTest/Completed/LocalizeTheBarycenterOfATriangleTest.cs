using CodeWars.Resolutions;

namespace CodeWarsTest.Completed;

public class LocalizeTheBarycenterOfATriangleTest
{
    [Test]
    public static void ExampleTests()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(LocalizeTheBarycenterOfATriangle.BarTriang(
                    [4, 6], [12, 4], [10, 10]),
                    Is.EqualTo([8.6667, 6.6667]));
            Assert.That(LocalizeTheBarycenterOfATriangle.BarTriang(
                [4, 2], [12, 2], [6, 10]),
                Is.EqualTo([7.3333, 4.6667]));
        }
    }
}
