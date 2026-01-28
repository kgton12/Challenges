using CodeWars.Resolutions;

namespace CodeWarsTest.Completed;

public class DontGiveMeFiveClassTest
{
    [Test]
    public void ExampleTests()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(DontGiveMeFiveClass.DontGiveMeFive(1, 9), Is.EqualTo(8));
            Assert.That(DontGiveMeFiveClass.DontGiveMeFive(4, 17), Is.EqualTo(12));
        }
    }
}
