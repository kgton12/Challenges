using CodeWars.Resolutions;

namespace CodeWarsTest.Completed;

public class FiveWithoutNumbersTest
{
    [Test]
    public void Test()
    {
        Assert.That(FiveWithoutNumbers.UnusualFive(), Is.EqualTo(5));
    }

}
