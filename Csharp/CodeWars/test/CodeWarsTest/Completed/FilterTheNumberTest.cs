using CodeWars.Resolutions;

namespace CodeWarsTest.Completed;

public class FilterTheNumberTest
{
    [Test]
    public static void FixedTests()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(FilterTheNumber.FilterString("123"), Is.EqualTo(123), "Just return the numbers");
            Assert.That(FilterTheNumber.FilterString("a1b2c3"), Is.EqualTo(123), "Just return the numbers");
            Assert.That(FilterTheNumber.FilterString("aa1bb2cc3dd"), Is.EqualTo(123), "Just return the numbers");
        }
    }
}
