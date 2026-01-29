using CodeWars.Resolutions;

namespace CodeWarsTest.Completed;

public class FindTheDivisorsTest
{
    [Test]
    public void SampleTest()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(FindTheDivisors.Divisors(15), Is.EqualTo([3, 5]), "n = 15");
            Assert.That(FindTheDivisors.Divisors(16), Is.EqualTo([2, 4, 8]), "n = 16");
            Assert.That(FindTheDivisors.Divisors(253), Is.EqualTo([11, 23]), "n = 253");
            Assert.That(FindTheDivisors.Divisors(24), Is.EqualTo([2, 3, 4, 6, 8, 12]), "n = 24");
            Assert.That(FindTheDivisors.Divisors(7), Is.Null, "n = 7");
        }
    }
}
