using CodeWars.Resolutions;

namespace CodeWarsTest.Completed;

public class CreditCardIssuerCheckingTest
{
    [TestCase(4111111111111111, "VISA")]
    [TestCase(6011111111111117, "Discover")]
    [TestCase(9111111111111111, "Unknown")]
    public void SampleTests(long input, string result)
    {
        Assert.That(CreditCardIssuerChecking.GetIsSuer(input), Is.EqualTo(result));
    }
}
