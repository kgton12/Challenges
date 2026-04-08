using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class CountingSheepTest
{
    [Test]
    [Order(1)]
    public void SampleTest()
    {
        bool[] sheeps = [true, false, true];

        Assert.That(CountingSheep.CountSheeps(sheeps), Is.EqualTo(2));
    }
}
