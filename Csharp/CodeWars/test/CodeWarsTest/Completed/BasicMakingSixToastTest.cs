using CodeWars.Resolutions;

namespace CodeWarsTest.Completed;

public class BasicMakingSixToastTest
{
    [Test]
    public void Test()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(BasicMakingSixToast.SixToast(6), Is.Zero);
            Assert.That(BasicMakingSixToast.SixToast(17), Is.EqualTo(11));
            Assert.That(BasicMakingSixToast.SixToast(3), Is.EqualTo(3));
        }
    }
}
