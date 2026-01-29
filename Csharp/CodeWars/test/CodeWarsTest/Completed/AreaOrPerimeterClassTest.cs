using CodeWars.Resolutions;

namespace CodeWarsTest.Completed;

public class AreaOrPerimeterClassTest
{
    [Test, Order(1)]
    public void FixedTest()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(AreaOrPerimeterClass.AreaOrPerimeter(4, 4), Is.EqualTo(16));
            Assert.That(AreaOrPerimeterClass.AreaOrPerimeter(6, 10), Is.EqualTo(32));
        }
    }
}
