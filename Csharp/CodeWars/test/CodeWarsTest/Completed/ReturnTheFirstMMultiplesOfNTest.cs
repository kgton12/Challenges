using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class ReturnTheFirstMMultiplesOfNTest
{
    [Test]
    public void SampleTests()
    {
        Assert.That(ReturnTheFirstMMultiplesOfN.Multiples(3, 5), Is.EqualTo([5, 10, 15]));
    }
}
