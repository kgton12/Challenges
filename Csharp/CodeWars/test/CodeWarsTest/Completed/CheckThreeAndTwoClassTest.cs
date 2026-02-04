using CodeWars.Resolutions;

namespace CodeWarsTest.Completed;

public class CheckThreeAndTwoClassTest
{
    [Test]
    public void MyTest()
    {
        Assert.That(CheckThreeAndTwoClass.CheckThreeAndTwo(new string[] { "a", "a", "a", "b", "b" }), Is.True);
        Assert.That(CheckThreeAndTwoClass.CheckThreeAndTwo(new string[] { "a", "c", "a", "c", "b" }), Is.False);
        Assert.That(CheckThreeAndTwoClass.CheckThreeAndTwo(new string[] { "a", "a", "a", "a", "a" }), Is.False);
    }
}
