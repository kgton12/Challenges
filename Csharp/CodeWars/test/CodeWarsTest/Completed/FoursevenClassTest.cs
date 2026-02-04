using CodeWars.Resolutions;

namespace CodeWarsTest.Completed;

public class FoursevenClassTest
{
    [Test, Order(1)]
    public void CorrectTests()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(FoursevenClass.FourSeven(4), Is.EqualTo(7));
            Assert.That(FoursevenClass.FourSeven(7), Is.EqualTo(4));
        }
    }

    [Test, Order(2)]
    public void WrongTests()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(FoursevenClass.FourSeven(100), Is.Zero);
            Assert.That(FoursevenClass.FourSeven(-17), Is.Zero);
        }
    }
}
