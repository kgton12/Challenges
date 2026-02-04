using CodeWars.Resolutions;

namespace CodeWarsTest.Completed;

public class SumOfABeachClassTest
{
    [Test]
    public void BasicTests()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(SumOfABeachClass.SumOfABeach("SanD"), Is.EqualTo(1));
            Assert.That(SumOfABeachClass.SumOfABeach("sunshine"), Is.EqualTo(1));
            Assert.That(SumOfABeachClass.SumOfABeach("sunsunsunsun"), Is.EqualTo(4));
            Assert.That(SumOfABeachClass.SumOfABeach("123FISH321"), Is.EqualTo(1));
        }
    }
}
