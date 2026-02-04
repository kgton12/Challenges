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
                    new double[] { 4, 6 }, new double[] { 12, 4 }, new double[] { 10, 10 }),
                    Is.EqualTo(new double[] { 8.6667, 6.6667 }));
            Assert.That(LocalizeTheBarycenterOfATriangle.BarTriang(
                new double[] { 4, 2 }, new double[] { 12, 2 }, new double[] { 6, 10 }),
                Is.EqualTo(new double[] { 7.3333, 4.6667 }));
        }
    }
}
