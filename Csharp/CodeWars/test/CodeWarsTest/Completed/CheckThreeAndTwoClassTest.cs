using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class CheckThreeAndTwoClassTest
{
    [Test]
    public void MyTest()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(CheckThreeAndTwoClass.CheckThreeAndTwo(["a", "a", "a", "b", "b"]), Is.True);
            Assert.That(CheckThreeAndTwoClass.CheckThreeAndTwo(["a", "c", "a", "c", "b"]), Is.False);
            Assert.That(CheckThreeAndTwoClass.CheckThreeAndTwo(["a", "a", "a", "a", "a"]), Is.False);
        }
    }
}
