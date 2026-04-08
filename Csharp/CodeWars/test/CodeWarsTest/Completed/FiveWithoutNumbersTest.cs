using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class FiveWithoutNumbersTest
{
    [Test]
    public void Test()
    {
        Assert.That(FiveWithoutNumbers.UnusualFive(), Is.EqualTo(5));
    }

}
