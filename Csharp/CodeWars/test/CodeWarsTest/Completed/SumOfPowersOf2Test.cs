using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class SumOfPowersOf2Test
{
    [Test]
    public void ExampleTests()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(SumOfPowersOf2.Powers(1), Is.EqualTo([1]));
            Assert.That(SumOfPowersOf2.Powers(2), Is.EqualTo([2]));
            Assert.That(SumOfPowersOf2.Powers(6), Is.EqualTo([2, 4]));
        }
    }
}
