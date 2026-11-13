using CodeWars.Completed;

namespace CodeWarsTest.Completed;

[TestFixture]
public class FormatNumberAsCurrencyUsingExtensionMethodTest
{
    [Test]
    public void When0ToDollarsReturnsDollar0_00()
    {
        Assert.That((0m).ToCurrency("$"), Is.EqualTo("$0.00"));
    }

    [Test]
    public void When1_23ToDollarsReturnsDollar1_23()
    {
        Assert.That((1.23m).ToCurrency("$"), Is.EqualTo("$1.23"));
    }

    [Test]
    public void When99_9999ToDollarsReturnsDollar100_00()
    {
        Assert.That((99.9999m).ToCurrency("$"), Is.EqualTo("$100.00"));
    }

    [Test]
    public void WhenNegative12345_6789ToDollarsReturnsMinusDollar12345__68()
    {
        Assert.That((-12345.6789m).ToCurrency("$"), Is.EqualTo("-$12345.68"));
    }

    [Test]
    public void When12345_6789ToPoundsReturnsPound12345__68()
    {
        Assert.That((12345.6789m).ToCurrency("£"), Is.EqualTo("£12345.68"));
    }
}
